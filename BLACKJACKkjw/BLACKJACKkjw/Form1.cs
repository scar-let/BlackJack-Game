using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLACKJACKkjw
{
    public partial class Form1 : Form
    {
        GameManager gameManager;
        private object msg;

        public Form1()
        {
            InitializeComponent();
            
        }

        public  void Form1_Paint(object sender, PaintEventArgs e)
        {
        
            

            // back ground image drawing            
            // left, top
            // top drawing : score(win, lose)
            string strScore;
            
            strScore = string.Format("현재점수 - Win : {0}, Lose : {1}", gameManager.user.WinCount, gameManager.user.LoseCount);

            
            e.Graphics.DrawString(strScore,
                Font, Brushes.Black, Form1_GroupBoxScore.Left + 5, Form1_GroupBoxScore.Top + 3);

            // computer card drawing
            if (gameManager.showResult == false)
                strScore = string.Format("컴퓨터");
            else
                strScore = string.Format("컴퓨터, 점수 : {0}", gameManager.computer.CalcScore());
            e.Graphics.DrawString(strScore,
               Font, Brushes.Black, Form1_GroupBoxComputerCard.Left, Form1_GroupBoxComputerCard.Top);
            int OffsetX = 105;
            for (int i = 0; i < gameManager.computer.CardCount; i++)
            {
                if ((gameManager.user.IsStand == false) && (i == gameManager.computer.CardCount - 1))
                {
                    Bitmap bitmapComputer = Properties.Resources.cardback_red;
                    e.Graphics.DrawImage(bitmapComputer, (i * OffsetX) + Form1_GroupBoxComputerCard.Left + 5, Form1_GroupBoxComputerCard.Top + 15);
                }
                else
                {
                    Bitmap bitmapComputer = GetCardBitmap(gameManager.computer.GetCard(i).iShape, gameManager.computer.GetCard(i).iIndex);
                    e.Graphics.DrawImage(bitmapComputer, (i * OffsetX) + Form1_GroupBoxComputerCard.Left + 5, Form1_GroupBoxComputerCard.Top + 15);
                }

            }

            // user card drawing
            if (gameManager.showResult == false)
                strScore = string.Format("유저");
            else
                strScore = string.Format("유저, 점수 : {0}", gameManager.user.CalcScore());
            e.Graphics.DrawString(strScore,
              Font, Brushes.Black, Form1_GroupBoxUserCard.Left, Form1_GroupBoxUserCard.Top);
            for (int i = 0; i < gameManager.user.CardCount; i++)
            {
                Bitmap bitmapUser = GetCardBitmap(gameManager.user.GetCard(i).iShape, gameManager.user.GetCard(i).iIndex);
                e.Graphics.DrawImage(bitmapUser, (i * OffsetX) + Form1_GroupBoxUserCard.Left + 5, Form1_GroupBoxUserCard.Top + 15);
            }

        }
        

        private void Form1_BtnHit_Click(object sender, EventArgs e)
        {
            gameManager.Hit();

            if (gameManager.user.CardCount >= 5)
                Form1_BtnHit.Enabled = false; // 5장 초과시 Hit 버튼 비활성화
            Invalidate();
        }

        private void Form1_BtnStand_Click(object sender, EventArgs e)
        {
            Form1_BtnHit.Enabled = false;
            Form1_BtnStand.Enabled = false;
            Invalidate();

            gameManager.Stand();

            //if (CardStore.CheakWin(int user int computer).retWin) {
               // MessageBox.Show("winCount"); }

            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameManager = new GameManager();

            Form1_BtnHit.Enabled = false;
            Form1_BtnStand.Enabled = false;
        }

        private Bitmap GetCardBitmap(int iShape, int iIndex)
        {
            Bitmap retBitmap = null;

            // heart
            if (iShape == 0 && iIndex == 0) // heart a
                retBitmap = Properties.Resources.h1;
            else if (iShape == 0 && iIndex == 1)
                retBitmap = Properties.Resources.h2;
            else if (iShape == 0 && iIndex == 2)
                retBitmap = Properties.Resources.h3;
            else if (iShape == 0 && iIndex == 3)
                retBitmap = Properties.Resources.h4;
            else if (iShape == 0 && iIndex == 4)
                retBitmap = Properties.Resources.h5;
            else if (iShape == 0 && iIndex == 5)
                retBitmap = Properties.Resources.h6;
            else if (iShape == 0 && iIndex == 6)
                retBitmap = Properties.Resources.h7;
            else if (iShape == 0 && iIndex == 7)
                retBitmap = Properties.Resources.h8;
            else if (iShape == 0 && iIndex == 8)
                retBitmap = Properties.Resources.h9;
            else if (iShape == 0 && iIndex == 9)
                retBitmap = Properties.Resources.h10;
            else if (iShape == 0 && iIndex == 10)
                retBitmap = Properties.Resources.hj;
            else if (iShape == 0 && iIndex == 11)
                retBitmap = Properties.Resources.hq;
            else if (iShape == 0 && iIndex == 12)
                retBitmap = Properties.Resources.hk;
            // diamond
            else if (iShape == 1 && iIndex == 0) // diamond a
                retBitmap = Properties.Resources.d1;
            else if (iShape == 1 && iIndex == 1)
                retBitmap = Properties.Resources.d2;
            else if (iShape == 1 && iIndex == 2)
                retBitmap = Properties.Resources.d3;
            else if (iShape == 1 && iIndex == 3)
                retBitmap = Properties.Resources.d4;
            else if (iShape == 1 && iIndex == 4)
                retBitmap = Properties.Resources.d5;
            else if (iShape == 1 && iIndex == 5)
                retBitmap = Properties.Resources.d6;
            else if (iShape == 1 && iIndex == 6)
                retBitmap = Properties.Resources.d7;
            else if (iShape == 1 && iIndex == 7)
                retBitmap = Properties.Resources.d8;
            else if (iShape == 1 && iIndex == 8)
                retBitmap = Properties.Resources.d9;
            else if (iShape == 1 && iIndex == 9)
                retBitmap = Properties.Resources.d10;
            else if (iShape == 1 && iIndex == 10)
                retBitmap = Properties.Resources.dj;
            else if (iShape == 1 && iIndex == 11)
                retBitmap = Properties.Resources.dq;
            else if (iShape == 1 && iIndex == 12)
                retBitmap = Properties.Resources.dk;
            // clover
            else if (iShape == 2 && iIndex == 0) // clover a
                retBitmap = Properties.Resources.c1;
            else if (iShape == 2 && iIndex == 1)
                retBitmap = Properties.Resources.c2;
            else if (iShape == 2 && iIndex == 2)
                retBitmap = Properties.Resources.c3;
            else if (iShape == 2 && iIndex == 3)
                retBitmap = Properties.Resources.c4;
            else if (iShape == 2 && iIndex == 4)
                retBitmap = Properties.Resources.c5;
            else if (iShape == 2 && iIndex == 5)
                retBitmap = Properties.Resources.c6;
            else if (iShape == 2 && iIndex == 6)
                retBitmap = Properties.Resources.c7;
            else if (iShape == 2 && iIndex == 7)
                retBitmap = Properties.Resources.c8;
            else if (iShape == 2 && iIndex == 8)
                retBitmap = Properties.Resources.c9;
            else if (iShape == 2 && iIndex == 9)
                retBitmap = Properties.Resources.c10;
            else if (iShape == 2 && iIndex == 10)
                retBitmap = Properties.Resources.cj;
            else if (iShape == 2 && iIndex == 11)
                retBitmap = Properties.Resources.cq;
            else if (iShape == 2 && iIndex == 12)
                retBitmap = Properties.Resources.ck;
            // spade
            else if (iShape == 3 && iIndex == 0) // spade a
                retBitmap = Properties.Resources.s1;
            else if (iShape == 3 && iIndex == 1)
                retBitmap = Properties.Resources.s2;
            else if (iShape == 3 && iIndex == 2)
                retBitmap = Properties.Resources.s3;
            else if (iShape == 3 && iIndex == 3)
                retBitmap = Properties.Resources.s4;
            else if (iShape == 3 && iIndex == 4)
                retBitmap = Properties.Resources.s5;
            else if (iShape == 3 && iIndex == 5)
                retBitmap = Properties.Resources.s6;
            else if (iShape == 3 && iIndex == 6)
                retBitmap = Properties.Resources.s7;
            else if (iShape == 3 && iIndex == 7)
                retBitmap = Properties.Resources.s8;
            else if (iShape == 3 && iIndex == 8)
                retBitmap = Properties.Resources.s9;
            else if (iShape == 3 && iIndex == 9)
                retBitmap = Properties.Resources.s10;
            else if (iShape == 3 && iIndex == 10)
                retBitmap = Properties.Resources.sj;
            else if (iShape == 3 && iIndex == 11)
                retBitmap = Properties.Resources.sq;
            else if (iShape == 3 && iIndex == 12)
                retBitmap = Properties.Resources.sk;

            return retBitmap;
        }

        private void Form1_BtnGameStart_Click(object sender, EventArgs e)
        {
            gameManager.Start();

            // display
            // hit/stand 버튼은 enable하라
            Form1_BtnHit.Enabled = true;
            Form1_BtnStand.Enabled = true;
            Invalidate();
        }

 
        private void Form1_BtnGameStart_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_BtnGameStart_MouseHover_1(object sender, EventArgs e)
        {
            Form1_BtnGameStart.BackColor = Color.FromArgb(204, 051, 051); //rgb색상
        }

        private void Form1_BtnGameInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("● 「21」을 최대값으로 가장 가까운 쪽이 승리한다.\n● 카드 J,Q,K이면 「10」을 더한다\n● 카드 A의 경우 「1」또는 「11」로 유리한 숫자를 선택한다.\n● 최대 5장까지 Hit 할수있다.\n● Stand를 누르면 결과를 확인한다.\n● User의 점수가 「21」점을 초과할 시 패배  ", "                            ♥◆게임정보♣♠ ");

        }
    }
}
