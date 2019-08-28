using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLACKJACKkjw
{
    public struct Card
    {
        public int iIndex; //   카드의 숫자 정보이다 0~12까지 A~K값에 대응한다.
        public int iShape; // 카드의 무늬 정보이다 0~3까지 하트,다이아몬드,클로버,스페이드 순서로 대응한다.
        public bool bUse;
        public void Clear()
        {
            iIndex = -1;
            iShape = -1;
            bUse = false;
        }
    }

    public class CardStore   // 13 x 4 개의 모든 종류의 카드를 가진 함수
    {
        Card[] HasCard;
        const int cardShapeMax = 4;
        const int cardIndexMax = 13;
        public CardStore()
        {
            // create card
            HasCard = new Card[cardIndexMax * cardShapeMax];

            for (int iShape = 0; iShape < cardShapeMax; iShape++)
            {
                for (int iIndex = 0; iIndex < cardIndexMax; iIndex++)
                {
                    HasCard[cardIndexMax * iShape + iIndex].Clear();
                }
            }
        }
        public void InitCard() // 카드를 새로 초기화한다 .
        {
            for (int iShape = 0; iShape < cardShapeMax; iShape++)
            {
                for (int iIndex = 0; iIndex < cardIndexMax; iIndex++)
                {
                    HasCard[cardIndexMax * iShape + iIndex].iShape = iShape;
                    HasCard[cardIndexMax * iShape + iIndex].iIndex = iIndex;
                    HasCard[cardIndexMax * iShape + iIndex].bUse = false;
                }
            }
        }
        public Card GetCard() // User나 Computer 가 카드를 1장 가지기 위한 함수.
        {
            Card retCard = new Card();
            int nCnt = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Random ran = new Random();
                int iIndex = ran.Next(0, cardIndexMax * cardShapeMax);

                if (HasCard[iIndex].bUse == false)
                {
                    retCard = HasCard[iIndex];
                    HasCard[iIndex].bUse = true;
                    break;
                }
                nCnt++;
                if (nCnt > 100) // 무한루프를 피하기위해 만듦
                    break;
            }
            return retCard;
        }
        public int CheckWin(int user, int computer) // User와 Computer 중  승리자를 판단하는 함수.
        {
            // ret 1 : user
            //     2 : computer
            //     0 : both
            
            int retWin = 0;
            //승자 판단부
            if (user == computer)
            {
                retWin = 0;
                
            }
            else if (user <= 21)//21 이하이다.
            {
                if (computer == 21)
                {
                    retWin = 2;
                }
                else if (computer > 21)
                {
                    retWin = 1;
                }
                else//둘다 21이하다.
                {
                    if (user > computer)
                    {
                        retWin = 1;
                    }
                    else if (user < computer)
                    {
                        retWin = 2;
                    }
                    else
                    {
                        retWin = 0;
                    }
                }
            }
            else// user가 21보다 크다.
            {
                if (computer == 21)
                {
                    retWin = 2;
                }
                else if (computer < 21)
                {
                    retWin = 2;
                }
                else  // computer가 21보다 크다
                {
                    if (user < computer)
                    {
                        retWin = 2;
                    }
                    else
                    {
                        retWin = 2;
                    }
                }
            }
            return retWin;
        }
    }

    public class Player // 게임을 하는 사람에 해당하는 기본 클래스.
    {
        protected Card[] hasCard;
        protected const int cardMax = 5; // 자신이 가진 카드 정보, 최대 5장까지 수령가능하다.
        protected int cardCount;
        protected bool isStand;
        protected int winCount;
        protected int loseCount;

        
        public int CardCount
        {
            get { return cardCount; }
        }
        public bool IsStand
        {
            get { return isStand; }
            
        }
        public int WinCount
        {
            get { return winCount; }
            
        }
        public int LoseCount
        {
            get { return loseCount; }
        }

        public Player()
        {
            // create card          
            hasCard = new Card[cardMax];
            for (int i = 0; i < cardMax; i++)
            {
                hasCard[i].Clear();
            }

            // 정보를 초기화한다.
            cardCount = 0;
            isStand = false;
            winCount = 0;
            loseCount = 0;
        }

        public void Init()
        {
            for (int i = 0; i < cardMax; i++)
            {
                hasCard[i].Clear();
            }
            cardCount = 0;
            isStand = false;
        }

        public void Hit(Card card) // 카드를 1장더 받는다.
        {
            if (cardCount == cardMax)
                return;
            hasCard[CardCount] = card;
            cardCount++;
        }
        public void Stand() // 카드 받는걸 중단한다.
        {
            isStand = true;
        }
        public virtual bool CheckStand()
        {
            // 게임을 중단 할지를 선택한다.
            // 이는 컴퓨터에만 해당하는 함수.
            return true;
        }

        public void SetWin(bool win) // 승패를 추가한다.
        {
            if (win == true)
                winCount++;
            else
                loseCount++;
        }

        public int CalcScore() // 현재카드의 점수를 계산하는 함수.
        {
            int retScore = 0;
                // 카드 A의 경우 1또는 11로 유리한 숫자를 선택한다.
                // JQK이면 10을 더함
                // 21을 최대값으로 가장 가까운 쪽이 승리한다.                     

            int iACount = 0;
            for (int iCard = 0; iCard < cardCount; iCard++)
            {
                // A = 0 , 10 = 9, J = 10, Q = 11, K = 12
                if (hasCard[iCard].iIndex == 10 || hasCard[iCard].iIndex == 11 || hasCard[iCard].iIndex == 12)//JQK이면 10을 더함
                {
                    retScore = retScore + 10;
                }
                else if (hasCard[iCard].iIndex == 0)//A이면 일단 skip
                {
                    // 일단 skip하고 추 후 계산함.
                    iACount++;
                }
                else// 1~10일경우 그대로 더함 
                {
                    retScore = retScore + (hasCard[iCard].iIndex + 1);
                }
            }

            // A에 대한 판정 1 or 11
            if (iACount > 0)
            {
                if ((retScore <= 10) && (iACount == 1))
                {
                    retScore = retScore + 11;
                }
                else
                {
                    retScore = retScore + (1 * iACount);
                }
            }

            return retScore;
        }

        public Card GetCard(int iIndex) // 선택한 iIndex에 해당하는 카드 정보를 리턴한다.
        {
            Card retCard = new Card();
            if (iIndex < cardCount)
                retCard = hasCard[iIndex];
            return retCard;
        }
    }

    public class User : Player // Player를 상속받는 User 클래스.
    {
        public override bool CheckStand()
        {
           
            return true;
        }
    }

    public class Computer : Player
    {
        public override bool CheckStand()
        {
            bool retStand = false;

            int totalScore = CalcScore();
            // check stand              
            if (totalScore >= 16) // 16점 이상이면 승률이 높으므로 stand
            {
                retStand = true;
            }
            else
            {
                retStand = false;  // 아닐경우 hit
            }

            return retStand;
        }
    }

    public class GameManager //User,Computer,CardStore를 멤버로 가지며 게임진행을 담당.
    {
        public CardStore cardStore;
        public Player user;
        public Player computer;
        public bool showResult;

        public GameManager()
        {
            cardStore = new CardStore();
            user = new User();
            computer = new Computer();
        }

        public void Start() // 게임을 시작하기위해 카드 및 기타 정보를 초기화.
        {
            // ready game  
            cardStore.InitCard();
            computer.Init();
            user.Init();
            showResult = false;

            // get two card
            computer.Hit(cardStore.GetCard());
            computer.Hit(cardStore.GetCard());

            user.Hit(cardStore.GetCard());
            user.Hit(cardStore.GetCard());
        }

        public void Hit() //User가 카드를 1장 더 받으며 Computer도 Hit or Stand 한다.
        {
            user.Hit(cardStore.GetCard());

            
            if (computer.IsStand == true)
            {
                
                ;
            }
            else
            {
                // check go or stand
                if (computer.CheckStand() == true)
                    computer.Stand();
                else
                    computer.Hit(cardStore.GetCard());
            }
        }

        public void Stand() // User가 카드 받는걸 중단하며 Computer는 나머지 카드에 대해 Hit or Stand 한다.
                                                // User,Computer가 모두 Stand이면 게임을 종료하고 결과를 보여준다.
        {
            user.Stand();

            
            if (computer.IsStand == true)
            {
                
                ;
            }
            else
            {
                // do computer for remain card
                while (true)
                {
                    if (computer.CardCount >= 5)
                    {
                        break;
                    }
                    else
                    {
                        if (computer.CheckStand() == true)
                        {
                            computer.Stand();
                            break;
                        }
                        else
                            computer.Hit(cardStore.GetCard());
                    }
                    System.Threading.Thread.Sleep(500);

                   
                }
            }

            // select which is win
            int iWin = cardStore.CheckWin(user.CalcScore(), computer.CalcScore());
            if (iWin == 1)
            {
               user.SetWin(true);
               
            }
            else if (iWin == 2)
            {
                user.SetWin(false);
            }
            else
            {
                ;
            }

            showResult = true;
            
        }
    }
}

