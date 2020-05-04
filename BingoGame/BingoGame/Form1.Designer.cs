namespace BingoGame
{
    partial class frmBingo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReadyToPlay = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.txtNumberCalled = new System.Windows.Forms.TextBox();
            this.lblBingoCard = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblWhatWeDo = new System.Windows.Forms.Label();
            this.lblDontHave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWelcome.Location = new System.Drawing.Point(271, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(675, 51);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Game of Bingo!";
            //this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(335, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Player Name:";
            //this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(518, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 29);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblReadyToPlay
            // 
            this.lblReadyToPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReadyToPlay.AutoSize = true;
            this.lblReadyToPlay.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToPlay.Location = new System.Drawing.Point(313, 168);
            this.lblReadyToPlay.Name = "lblReadyToPlay";
            this.lblReadyToPlay.Size = new System.Drawing.Size(175, 25);
            this.lblReadyToPlay.TabIndex = 3;
            this.lblReadyToPlay.Text = "Ready to Play?";
            //this.lblReadyToPlay.Click += new System.EventHandler(this.lblReadyToPlay_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Lime;
            this.btnPlay.Location = new System.Drawing.Point(504, 157);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(171, 50);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Yes! Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(726, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No! Exit!";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCard.Location = new System.Drawing.Point(340, 391);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(566, 568);
            this.pnlCard.TabIndex = 6;
            //this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDontHave
            // 
            this.btnDontHave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDontHave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDontHave.Enabled = false;
            this.btnDontHave.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDontHave.Location = new System.Drawing.Point(944, 284);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(167, 50);
            this.btnDontHave.TabIndex = 7;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // txtNumberCalled
            // 
            this.txtNumberCalled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumberCalled.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCalled.Location = new System.Drawing.Point(944, 233);
            this.txtNumberCalled.Name = "txtNumberCalled";
            this.txtNumberCalled.ReadOnly = true;
            this.txtNumberCalled.Size = new System.Drawing.Size(167, 40);
            this.txtNumberCalled.TabIndex = 8;
            //this.txtNumberCalled.TextChanged += new System.EventHandler(this.txtNumberCalled_TextChanged);
            // 
            // lblBingoCard
            // 
            this.lblBingoCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBingoCard.AutoSize = true;
            this.lblBingoCard.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBingoCard.Location = new System.Drawing.Point(498, 345);
            this.lblBingoCard.Name = "lblBingoCard";
            this.lblBingoCard.Size = new System.Drawing.Size(236, 31);
            this.lblBingoCard.TabIndex = 9;
            this.lblBingoCard.Text = "Your Bingo Card";
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.Location = new System.Drawing.Point(165, 233);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(756, 23);
            this.lblHowToPlay.TabIndex = 10;
            this.lblHowToPlay.Text = "We call one number at a time. Check your card for that number, and if found, clic" +
    "k that cell.\r\n";
            // 
            // lblWhatWeDo
            // 
            this.lblWhatWeDo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWhatWeDo.AutoSize = true;
            this.lblWhatWeDo.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatWeDo.Location = new System.Drawing.Point(165, 265);
            this.lblWhatWeDo.Name = "lblWhatWeDo";
            this.lblWhatWeDo.Size = new System.Drawing.Size(754, 23);
            this.lblWhatWeDo.TabIndex = 11;
            this.lblWhatWeDo.Text = "We will do the rest, checking for a Bingo or not. That number called will appear " +
    "to the right.";
            // 
            // lblDontHave
            // 
            this.lblDontHave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDontHave.AutoSize = true;
            this.lblDontHave.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHave.Location = new System.Drawing.Point(165, 299);
            this.lblDontHave.Name = "lblDontHave";
            this.lblDontHave.Size = new System.Drawing.Size(759, 23);
            this.lblDontHave.TabIndex = 12;
            this.lblDontHave.Text = "If you do not have the number called in your card, click the \"Don\'t Have\" button " +
    "to the right.";
            // 
            // frmBingo
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1175, 1055);
            this.Controls.Add(this.lblDontHave);
            this.Controls.Add(this.lblWhatWeDo);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblBingoCard);
            this.Controls.Add(this.txtNumberCalled);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblReadyToPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmBingo";
            this.Text = "BINGO";
            //this.Load += new System.EventHandler(this.Form1_Load);
            //this.TextChanged += new System.EventHandler(this.txtNumberCalled_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReadyToPlay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.TextBox txtNumberCalled;
        private System.Windows.Forms.Label lblBingoCard;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblWhatWeDo;
        private System.Windows.Forms.Label lblDontHave;
    }
}

