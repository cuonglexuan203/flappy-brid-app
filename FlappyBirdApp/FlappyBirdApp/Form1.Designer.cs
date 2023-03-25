﻿namespace FlappyBirdApp
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
            this.LbInstructionStart = new System.Windows.Forms.Label();
            this.LbGameOver = new System.Windows.Forms.Label();
            this.LbScore = new System.Windows.Forms.Label();
            this.PBGround = new System.Windows.Forms.PictureBox();
            this.PBPipeDown = new System.Windows.Forms.PictureBox();
            this.PBPipeUp = new System.Windows.Forms.PictureBox();
            this.PBBird = new System.Windows.Forms.PictureBox();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.BtMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlContainer.SuspendLayout();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBird)).BeginInit();
            this.PnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContainer
            // 
            this.PnlContainer.Controls.Add(this.PnlMain);
            this.PnlContainer.Controls.Add(this.PnlControl);
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(439, 786);
            this.PnlContainer.TabIndex = 0;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.Aqua;
            this.PnlMain.Controls.Add(this.LbInstructionStart);
            this.PnlMain.Controls.Add(this.LbGameOver);
            this.PnlMain.Controls.Add(this.LbScore);
            this.PnlMain.Controls.Add(this.PBGround);
            this.PnlMain.Controls.Add(this.PBPipeDown);
            this.PnlMain.Controls.Add(this.PBPipeUp);
            this.PnlMain.Controls.Add(this.PBBird);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 41);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(439, 745);
            this.PnlMain.TabIndex = 1;
            // 
            // LbInstructionStart
            // 
            this.LbInstructionStart.AutoSize = true;
            this.LbInstructionStart.BackColor = System.Drawing.Color.Transparent;
            this.LbInstructionStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbInstructionStart.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInstructionStart.Location = new System.Drawing.Point(143, 283);
            this.LbInstructionStart.Name = "LbInstructionStart";
            this.LbInstructionStart.Size = new System.Drawing.Size(230, 21);
            this.LbInstructionStart.TabIndex = 6;
            this.LbInstructionStart.Text = "Press a key to start";
            // 
            // LbGameOver
            // 
            this.LbGameOver.AutoSize = true;
            this.LbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.LbGameOver.Font = new System.Drawing.Font("Hack NFM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGameOver.ForeColor = System.Drawing.Color.Red;
            this.LbGameOver.Location = new System.Drawing.Point(139, 237);
            this.LbGameOver.Margin = new System.Windows.Forms.Padding(0);
            this.LbGameOver.Name = "LbGameOver";
            this.LbGameOver.Size = new System.Drawing.Size(236, 46);
            this.LbGameOver.TabIndex = 5;
            this.LbGameOver.Text = "Game Over";
            this.LbGameOver.Visible = false;
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.Font = new System.Drawing.Font("Hack NFM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.ForeColor = System.Drawing.Color.Black;
            this.LbScore.Location = new System.Drawing.Point(214, 19);
            this.LbScore.Margin = new System.Windows.Forms.Padding(0);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(33, 35);
            this.LbScore.TabIndex = 4;
            this.LbScore.Text = "0";
            // 
            // PBGround
            // 
            this.PBGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBGround.Image = ((System.Drawing.Image)(resources.GetObject("PBGround.Image")));
            this.PBGround.Location = new System.Drawing.Point(0, 669);
            this.PBGround.Name = "PBGround";
            this.PBGround.Size = new System.Drawing.Size(439, 76);
            this.PBGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBGround.TabIndex = 3;
            this.PBGround.TabStop = false;
            // 
            // PBPipeDown
            // 
            this.PBPipeDown.Image = ((System.Drawing.Image)(resources.GetObject("PBPipeDown.Image")));
            this.PBPipeDown.Location = new System.Drawing.Point(324, -117);
            this.PBPipeDown.Margin = new System.Windows.Forms.Padding(0);
            this.PBPipeDown.Name = "PBPipeDown";
            this.PBPipeDown.Size = new System.Drawing.Size(91, 324);
            this.PBPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPipeDown.TabIndex = 2;
            this.PBPipeDown.TabStop = false;
            // 
            // PBPipeUp
            // 
            this.PBPipeUp.Image = ((System.Drawing.Image)(resources.GetObject("PBPipeUp.Image")));
            this.PBPipeUp.Location = new System.Drawing.Point(311, 426);
            this.PBPipeUp.Margin = new System.Windows.Forms.Padding(0);
            this.PBPipeUp.Name = "PBPipeUp";
            this.PBPipeUp.Size = new System.Drawing.Size(91, 364);
            this.PBPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPipeUp.TabIndex = 1;
            this.PBPipeUp.TabStop = false;
            // 
            // PBBird
            // 
            this.PBBird.Image = ((System.Drawing.Image)(resources.GetObject("PBBird.Image")));
            this.PBBird.Location = new System.Drawing.Point(90, 314);
            this.PBBird.Margin = new System.Windows.Forms.Padding(0);
            this.PBBird.Name = "PBBird";
            this.PBBird.Size = new System.Drawing.Size(61, 53);
            this.PBBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBird.TabIndex = 0;
            this.PBBird.TabStop = false;
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
            this.PnlControl.Size = new System.Drawing.Size(439, 41);
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
            this.BtMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMinimize.Font = new System.Drawing.Font("Hack NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMinimize.Location = new System.Drawing.Point(315, 0);
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
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(377, 0);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AppForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AppForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AppForm_KeyUp);
            this.PnlContainer.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBird)).EndInit();
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
        private System.Windows.Forms.PictureBox PBBird;
        private System.Windows.Forms.PictureBox PBPipeUp;
        private System.Windows.Forms.PictureBox PBPipeDown;
        private System.Windows.Forms.PictureBox PBGround;
        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.Label LbGameOver;
        private System.Windows.Forms.PictureBox PbIcon;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label LbInstructionStart;
        private System.Windows.Forms.Timer pipeTimer;
    }
}
