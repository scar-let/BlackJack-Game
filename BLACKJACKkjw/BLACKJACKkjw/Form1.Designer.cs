namespace BLACKJACKkjw
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Form1_BtnStand = new System.Windows.Forms.Button();
            this.Form1_BtnHit = new System.Windows.Forms.Button();
            this.Form1_BtnGameStart = new System.Windows.Forms.Button();
            this.Form1_GroupBoxScore = new System.Windows.Forms.GroupBox();
            this.Form1_GroupBoxUserCard = new System.Windows.Forms.GroupBox();
            this.Form1_GroupBoxComputerCard = new System.Windows.Forms.GroupBox();
            this.Form1_BtnGameInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form1_BtnStand
            // 
            this.Form1_BtnStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form1_BtnStand.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1_BtnStand.Location = new System.Drawing.Point(593, 358);
            this.Form1_BtnStand.Name = "Form1_BtnStand";
            this.Form1_BtnStand.Size = new System.Drawing.Size(94, 37);
            this.Form1_BtnStand.TabIndex = 4;
            this.Form1_BtnStand.Text = "Stand";
            this.Form1_BtnStand.UseVisualStyleBackColor = true;
            this.Form1_BtnStand.Click += new System.EventHandler(this.Form1_BtnStand_Click);
            // 
            // Form1_BtnHit
            // 
            this.Form1_BtnHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form1_BtnHit.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1_BtnHit.Location = new System.Drawing.Point(593, 302);
            this.Form1_BtnHit.Name = "Form1_BtnHit";
            this.Form1_BtnHit.Size = new System.Drawing.Size(94, 37);
            this.Form1_BtnHit.TabIndex = 3;
            this.Form1_BtnHit.Text = "Hit";
            this.Form1_BtnHit.UseVisualStyleBackColor = true;
            this.Form1_BtnHit.Click += new System.EventHandler(this.Form1_BtnHit_Click);
            // 
            // Form1_BtnGameStart
            // 
            this.Form1_BtnGameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form1_BtnGameStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Form1_BtnGameStart.FlatAppearance.BorderSize = 10;
            this.Form1_BtnGameStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Form1_BtnGameStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Form1_BtnGameStart.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1_BtnGameStart.Location = new System.Drawing.Point(593, 247);
            this.Form1_BtnGameStart.Name = "Form1_BtnGameStart";
            this.Form1_BtnGameStart.Size = new System.Drawing.Size(94, 37);
            this.Form1_BtnGameStart.TabIndex = 0;
            this.Form1_BtnGameStart.Text = "Game Start";
            this.Form1_BtnGameStart.UseVisualStyleBackColor = true;
            this.Form1_BtnGameStart.Click += new System.EventHandler(this.Form1_BtnGameStart_Click);
            this.Form1_BtnGameStart.MouseHover += new System.EventHandler(this.Form1_BtnGameStart_MouseHover_1);
            this.Form1_BtnGameStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_BtnGameStart_MouseMove);
            // 
            // Form1_GroupBoxScore
            // 
            this.Form1_GroupBoxScore.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1_GroupBoxScore.Location = new System.Drawing.Point(27, 2);
            this.Form1_GroupBoxScore.Name = "Form1_GroupBoxScore";
            this.Form1_GroupBoxScore.Size = new System.Drawing.Size(528, 42);
            this.Form1_GroupBoxScore.TabIndex = 5;
            this.Form1_GroupBoxScore.TabStop = false;
            this.Form1_GroupBoxScore.Text = "현재 점수";
            this.Form1_GroupBoxScore.Visible = false;
            // 
            // Form1_GroupBoxUserCard
            // 
            this.Form1_GroupBoxUserCard.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1_GroupBoxUserCard.Location = new System.Drawing.Point(26, 232);
            this.Form1_GroupBoxUserCard.Name = "Form1_GroupBoxUserCard";
            this.Form1_GroupBoxUserCard.Size = new System.Drawing.Size(529, 176);
            this.Form1_GroupBoxUserCard.TabIndex = 2;
            this.Form1_GroupBoxUserCard.TabStop = false;
            this.Form1_GroupBoxUserCard.Text = "유저 카드";
            this.Form1_GroupBoxUserCard.Visible = false;
            // 
            // Form1_GroupBoxComputerCard
            // 
            this.Form1_GroupBoxComputerCard.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1_GroupBoxComputerCard.Location = new System.Drawing.Point(23, 56);
            this.Form1_GroupBoxComputerCard.Name = "Form1_GroupBoxComputerCard";
            this.Form1_GroupBoxComputerCard.Size = new System.Drawing.Size(529, 169);
            this.Form1_GroupBoxComputerCard.TabIndex = 1;
            this.Form1_GroupBoxComputerCard.TabStop = false;
            this.Form1_GroupBoxComputerCard.Text = "컴퓨터 카드";
            this.Form1_GroupBoxComputerCard.Visible = false;
            // 
            // Form1_BtnGameInfo
            // 
            this.Form1_BtnGameInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.Form1_BtnGameInfo.Location = new System.Drawing.Point(593, 12);
            this.Form1_BtnGameInfo.Name = "Form1_BtnGameInfo";
            this.Form1_BtnGameInfo.Size = new System.Drawing.Size(94, 37);
            this.Form1_BtnGameInfo.TabIndex = 6;
            this.Form1_BtnGameInfo.Text = "Info";
            this.Form1_BtnGameInfo.UseVisualStyleBackColor = true;
            this.Form1_BtnGameInfo.Click += new System.EventHandler(this.Form1_BtnGameInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(699, 422);
            this.Controls.Add(this.Form1_BtnGameInfo);
            this.Controls.Add(this.Form1_GroupBoxScore);
            this.Controls.Add(this.Form1_GroupBoxUserCard);
            this.Controls.Add(this.Form1_GroupBoxComputerCard);
            this.Controls.Add(this.Form1_BtnStand);
            this.Controls.Add(this.Form1_BtnHit);
            this.Controls.Add(this.Form1_BtnGameStart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BlackJack Game  by kjw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form1_BtnStand;
        private System.Windows.Forms.Button Form1_BtnHit;
        private System.Windows.Forms.Button Form1_BtnGameStart;
        private System.Windows.Forms.GroupBox Form1_GroupBoxScore;
        private System.Windows.Forms.GroupBox Form1_GroupBoxUserCard;
        private System.Windows.Forms.GroupBox Form1_GroupBoxComputerCard;
        private System.Windows.Forms.Button Form1_BtnGameInfo;
    }
}

