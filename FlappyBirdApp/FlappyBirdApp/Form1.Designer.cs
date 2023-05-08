namespace FlappyBirdApp
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlGamePlay = new System.Windows.Forms.Panel();
            this.LbCountDown = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.PnlShow = new System.Windows.Forms.Panel();
            this.LbHighestScoreValue = new System.Windows.Forms.Label();
            this.LbHighestScrore = new System.Windows.Forms.Label();
            this.BtnScore = new System.Windows.Forms.Button();
            this.LbScore = new System.Windows.Forms.Label();
            this.LbGameOver = new System.Windows.Forms.Label();
            this.PBPipeDown = new System.Windows.Forms.PictureBox();
            this.PBPipeUp = new System.Windows.Forms.PictureBox();
            this.PBBird = new System.Windows.Forms.PictureBox();
            this.LbInstructionStart = new System.Windows.Forms.Label();
            this.PBGround = new System.Windows.Forms.PictureBox();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.BtMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlContainer.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.PnlGamePlay.SuspendLayout();
            this.PnlShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGround)).BeginInit();
            this.PnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContainer
            // 
            this.PnlContainer.Controls.Add(this.PnlMain);
            this.PnlContainer.Controls.Add(this.PnlControl);
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(1, 1);
            this.PnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(437, 784);
            this.PnlContainer.TabIndex = 0;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.Transparent;
            this.PnlMain.Controls.Add(this.LbInstructionStart);
            this.PnlMain.Controls.Add(this.LbScore);
            this.PnlMain.Controls.Add(this.PnlGamePlay);
            this.PnlMain.Controls.Add(this.PBGround);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 41);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(437, 743);
            this.PnlMain.TabIndex = 1;
            // 
            // PnlGamePlay
            // 
            this.PnlGamePlay.BackgroundImage = global::FlappyBirdApp.Properties.Resources.background1;
            this.PnlGamePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlGamePlay.Controls.Add(this.LbCountDown);
            this.PnlGamePlay.Controls.Add(this.BtnPlay);
            this.PnlGamePlay.Controls.Add(this.PnlShow);
            this.PnlGamePlay.Controls.Add(this.BtnScore);
            this.PnlGamePlay.Controls.Add(this.LbGameOver);
            this.PnlGamePlay.Controls.Add(this.PBPipeDown);
            this.PnlGamePlay.Controls.Add(this.PBPipeUp);
            this.PnlGamePlay.Controls.Add(this.PBBird);
            this.PnlGamePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGamePlay.Location = new System.Drawing.Point(0, 0);
            this.PnlGamePlay.Margin = new System.Windows.Forms.Padding(0);
            this.PnlGamePlay.Name = "PnlGamePlay";
            this.PnlGamePlay.Size = new System.Drawing.Size(437, 667);
            this.PnlGamePlay.TabIndex = 7;
            // 
            // LbCountDown
            // 
            this.LbCountDown.AutoSize = true;
            this.LbCountDown.Font = new System.Drawing.Font("Hack NF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountDown.ForeColor = System.Drawing.Color.Red;
            this.LbCountDown.Location = new System.Drawing.Point(208, 266);
            this.LbCountDown.Name = "LbCountDown";
            this.LbCountDown.Size = new System.Drawing.Size(44, 46);
            this.LbCountDown.TabIndex = 19;
            this.LbCountDown.Text = "3";
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Hack NFM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Location = new System.Drawing.Point(174, 403);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(88, 48);
            this.BtnPlay.TabIndex = 18;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // PnlShow
            // 
            this.PnlShow.BackColor = System.Drawing.Color.Transparent;
            this.PnlShow.Controls.Add(this.LbHighestScoreValue);
            this.PnlShow.Controls.Add(this.LbHighestScrore);
            this.PnlShow.Location = new System.Drawing.Point(125, 355);
            this.PnlShow.Margin = new System.Windows.Forms.Padding(0);
            this.PnlShow.Name = "PnlShow";
            this.PnlShow.Size = new System.Drawing.Size(244, 29);
            this.PnlShow.TabIndex = 17;
            // 
            // LbHighestScoreValue
            // 
            this.LbHighestScoreValue.AutoSize = true;
            this.LbHighestScoreValue.Font = new System.Drawing.Font("Hack NFM", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHighestScoreValue.Location = new System.Drawing.Point(218, 0);
            this.LbHighestScoreValue.Name = "LbHighestScoreValue";
            this.LbHighestScoreValue.Size = new System.Drawing.Size(26, 26);
            this.LbHighestScoreValue.TabIndex = 16;
            this.LbHighestScoreValue.Text = "0";
            // 
            // LbHighestScrore
            // 
            this.LbHighestScrore.AutoSize = true;
            this.LbHighestScrore.Font = new System.Drawing.Font("Hack NFM", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHighestScrore.Location = new System.Drawing.Point(3, 0);
            this.LbHighestScrore.Name = "LbHighestScrore";
            this.LbHighestScrore.Size = new System.Drawing.Size(222, 26);
            this.LbHighestScrore.TabIndex = 15;
            this.LbHighestScrore.Text = "Highest Score: ";
            // 
            // BtnScore
            // 
            this.BtnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.BtnScore.FlatAppearance.BorderSize = 0;
            this.BtnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScore.Font = new System.Drawing.Font("Hack NFM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScore.ForeColor = System.Drawing.Color.White;
            this.BtnScore.Location = new System.Drawing.Point(173, 483);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(88, 48);
            this.BtnScore.TabIndex = 16;
            this.BtnScore.TabStop = false;
            this.BtnScore.Text = "Score";
            this.BtnScore.UseVisualStyleBackColor = false;
            this.BtnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.LbScore.Font = new System.Drawing.Font("Hack NFM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.ForeColor = System.Drawing.Color.Black;
            this.LbScore.Location = new System.Drawing.Point(196, 683);
            this.LbScore.Margin = new System.Windows.Forms.Padding(0);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(33, 35);
            this.LbScore.TabIndex = 9;
            this.LbScore.Text = "0";
            // 
            // LbGameOver
            // 
            this.LbGameOver.AutoSize = true;
            this.LbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.LbGameOver.Font = new System.Drawing.Font("Hack NFM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGameOver.ForeColor = System.Drawing.Color.Red;
            this.LbGameOver.Location = new System.Drawing.Point(119, 266);
            this.LbGameOver.Margin = new System.Windows.Forms.Padding(0);
            this.LbGameOver.Name = "LbGameOver";
            this.LbGameOver.Size = new System.Drawing.Size(236, 46);
            this.LbGameOver.TabIndex = 10;
            this.LbGameOver.Text = "Game Over";
            this.LbGameOver.Visible = false;
            // 
            // PBPipeDown
            // 
            this.PBPipeDown.Image = ((System.Drawing.Image)(resources.GetObject("PBPipeDown.Image")));
            this.PBPipeDown.Location = new System.Drawing.Point(292, -137);
            this.PBPipeDown.Margin = new System.Windows.Forms.Padding(0);
            this.PBPipeDown.Name = "PBPipeDown";
            this.PBPipeDown.Size = new System.Drawing.Size(91, 370);
            this.PBPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPipeDown.TabIndex = 8;
            this.PBPipeDown.TabStop = false;
            // 
            // PBPipeUp
            // 
            this.PBPipeUp.Image = ((System.Drawing.Image)(resources.GetObject("PBPipeUp.Image")));
            this.PBPipeUp.Location = new System.Drawing.Point(264, 436);
            this.PBPipeUp.Margin = new System.Windows.Forms.Padding(0);
            this.PBPipeUp.Name = "PBPipeUp";
            this.PBPipeUp.Size = new System.Drawing.Size(91, 370);
            this.PBPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPipeUp.TabIndex = 7;
            this.PBPipeUp.TabStop = false;
            // 
            // PBBird
            // 
            this.PBBird.BackColor = System.Drawing.Color.Transparent;
            this.PBBird.Image = global::FlappyBirdApp.Properties.Resources.bird_normal;
            this.PBBird.Location = new System.Drawing.Point(55, 342);
            this.PBBird.Margin = new System.Windows.Forms.Padding(0);
            this.PBBird.Name = "PBBird";
            this.PBBird.Size = new System.Drawing.Size(70, 53);
            this.PBBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBird.TabIndex = 6;
            this.PBBird.TabStop = false;
            // 
            // LbInstructionStart
            // 
            this.LbInstructionStart.AutoSize = true;
            this.LbInstructionStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.LbInstructionStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbInstructionStart.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInstructionStart.ForeColor = System.Drawing.Color.Black;
            this.LbInstructionStart.Location = new System.Drawing.Point(121, 712);
            this.LbInstructionStart.Name = "LbInstructionStart";
            this.LbInstructionStart.Size = new System.Drawing.Size(230, 21);
            this.LbInstructionStart.TabIndex = 6;
            this.LbInstructionStart.Text = "Press space to start";
            // 
            // PBGround
            // 
            this.PBGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBGround.Image = ((System.Drawing.Image)(resources.GetObject("PBGround.Image")));
            this.PBGround.Location = new System.Drawing.Point(0, 667);
            this.PBGround.Name = "PBGround";
            this.PBGround.Size = new System.Drawing.Size(437, 76);
            this.PBGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBGround.TabIndex = 3;
            this.PBGround.TabStop = false;
            // 
            // PnlControl
            // 
            this.PnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.PnlControl.Controls.Add(this.LbTitle);
            this.PnlControl.Controls.Add(this.PbIcon);
            this.PnlControl.Controls.Add(this.BtMinimize);
            this.PnlControl.Controls.Add(this.BtnExit);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Margin = new System.Windows.Forms.Padding(0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(437, 41);
            this.PnlControl.TabIndex = 0;
            this.PnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Handler_SetMouseOffset);
            this.PnlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Handler_MovingForm);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(53, 15);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(107, 18);
            this.LbTitle.TabIndex = 5;
            this.LbTitle.Text = "Flappy Bird";
            this.LbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Handler_SetMouseOffset);
            this.LbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Handler_MovingForm);
            // 
            // PbIcon
            // 
            this.PbIcon.BackColor = System.Drawing.Color.Transparent;
            this.PbIcon.Image = ((System.Drawing.Image)(resources.GetObject("PbIcon.Image")));
            this.PbIcon.Location = new System.Drawing.Point(3, 3);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(44, 35);
            this.PbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbIcon.TabIndex = 4;
            this.PbIcon.TabStop = false;
            this.PbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Handler_SetMouseOffset);
            this.PbIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Handler_MovingForm);
            // 
            // BtMinimize
            // 
            this.BtMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtMinimize.FlatAppearance.BorderSize = 0;
            this.BtMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMinimize.Font = new System.Drawing.Font("Hack NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMinimize.Location = new System.Drawing.Point(313, 0);
            this.BtMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtMinimize.Name = "BtMinimize";
            this.BtMinimize.Size = new System.Drawing.Size(62, 41);
            this.BtMinimize.TabIndex = 2;
            this.BtMinimize.TabStop = false;
            this.BtMinimize.Tag = "minimize";
            this.BtMinimize.Text = "-";
            this.BtMinimize.UseVisualStyleBackColor = false;
            this.BtMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Handler_FormBtn_Click);
            this.BtMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Handler_FormBtn_MouseDown);
            this.BtMinimize.MouseEnter += new System.EventHandler(this.Handler_FormBtn_MouseEnter);
            this.BtMinimize.MouseLeave += new System.EventHandler(this.Handler_FormBtn_MouseLeave);
            this.BtMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Handler_FormBtn_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(375, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(62, 41);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Tag = "exit";
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Handler_FormBtn_Click);
            this.BtnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Handler_FormBtn_MouseDown);
            this.BtnExit.MouseEnter += new System.EventHandler(this.Handler_FormBtn_MouseEnter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.Handler_FormBtn_MouseLeave);
            this.BtnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Handler_FormBtn_MouseUp);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 2;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // pipeTimer
            // 
            this.pipeTimer.Interval = 30;
            this.pipeTimer.Tick += new System.EventHandler(this.pipeTimer_Tick);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 786);
            this.Controls.Add(this.PnlContainer);
            this.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AppForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AppForm_KeyUp);
            this.PnlContainer.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.PnlGamePlay.ResumeLayout(false);
            this.PnlGamePlay.PerformLayout();
            this.PnlShow.ResumeLayout(false);
            this.PnlShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGround)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.PnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtMinimize;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox PBGround;
        private System.Windows.Forms.PictureBox PbIcon;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label LbInstructionStart;
        private System.Windows.Forms.Timer pipeTimer;
        private System.Windows.Forms.Panel PnlGamePlay;
        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.Label LbGameOver;
        private System.Windows.Forms.PictureBox PBPipeDown;
        private System.Windows.Forms.PictureBox PBPipeUp;
        private System.Windows.Forms.PictureBox PBBird;
        private System.Windows.Forms.Panel PnlShow;
        private System.Windows.Forms.Label LbHighestScoreValue;
        private System.Windows.Forms.Label LbHighestScrore;
        private System.Windows.Forms.Button BtnScore;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label LbCountDown;
    }
}

