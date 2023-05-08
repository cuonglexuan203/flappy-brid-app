namespace FlappyBirdApp.Src.Controllers
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PnlGamePlay = new System.Windows.Forms.Panel();
            this.PBGround = new System.Windows.Forms.PictureBox();
            this.PBBird = new System.Windows.Forms.PictureBox();
            this.LbInstructionStart = new System.Windows.Forms.Label();
            this.PnlGamePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBird)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGamePlay
            // 
            this.PnlGamePlay.BackgroundImage = global::FlappyBirdApp.Properties.Resources.background1;
            this.PnlGamePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlGamePlay.Controls.Add(this.LbInstructionStart);
            this.PnlGamePlay.Controls.Add(this.PBBird);
            this.PnlGamePlay.Controls.Add(this.PBGround);
            this.PnlGamePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGamePlay.Location = new System.Drawing.Point(1, 1);
            this.PnlGamePlay.Margin = new System.Windows.Forms.Padding(0);
            this.PnlGamePlay.Name = "PnlGamePlay";
            this.PnlGamePlay.Size = new System.Drawing.Size(435, 665);
            this.PnlGamePlay.TabIndex = 0;
            // 
            // PBGround
            // 
            this.PBGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBGround.Image = ((System.Drawing.Image)(resources.GetObject("PBGround.Image")));
            this.PBGround.Location = new System.Drawing.Point(0, 589);
            this.PBGround.Name = "PBGround";
            this.PBGround.Size = new System.Drawing.Size(435, 76);
            this.PBGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBGround.TabIndex = 9;
            this.PBGround.TabStop = false;
            // 
            // PBBird
            // 
            this.PBBird.BackColor = System.Drawing.Color.Transparent;
            this.PBBird.Image = global::FlappyBirdApp.Properties.Resources.bird_normal;
            this.PBBird.Location = new System.Drawing.Point(27, 322);
            this.PBBird.Margin = new System.Windows.Forms.Padding(0);
            this.PBBird.Name = "PBBird";
            this.PBBird.Size = new System.Drawing.Size(70, 53);
            this.PBBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBird.TabIndex = 10;
            this.PBBird.TabStop = false;
            // 
            // LbInstructionStart
            // 
            this.LbInstructionStart.AutoSize = true;
            this.LbInstructionStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.LbInstructionStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbInstructionStart.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInstructionStart.ForeColor = System.Drawing.Color.Black;
            this.LbInstructionStart.Location = new System.Drawing.Point(102, 322);
            this.LbInstructionStart.Name = "LbInstructionStart";
            this.LbInstructionStart.Size = new System.Drawing.Size(230, 21);
            this.LbInstructionStart.TabIndex = 11;
            this.LbInstructionStart.Text = "Press space to start";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 667);
            this.Controls.Add(this.PnlGamePlay);
            this.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.PnlGamePlay.ResumeLayout(false);
            this.PnlGamePlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGamePlay;
        private System.Windows.Forms.PictureBox PBGround;
        private System.Windows.Forms.PictureBox PBBird;
        private System.Windows.Forms.Label LbInstructionStart;
    }
}