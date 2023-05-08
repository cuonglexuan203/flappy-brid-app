namespace FlappyBirdApp.Src.Controllers
{
    partial class HighScore
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
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.LbGameOver = new System.Windows.Forms.Label();
            this.LbScore = new System.Windows.Forms.Label();
            this.PnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.PnlContainer.Controls.Add(this.LbScore);
            this.PnlContainer.Controls.Add(this.LbGameOver);
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(328, 95);
            this.PnlContainer.TabIndex = 0;
            // 
            // LbGameOver
            // 
            this.LbGameOver.AutoSize = true;
            this.LbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.LbGameOver.Font = new System.Drawing.Font("Hack NFM", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGameOver.ForeColor = System.Drawing.Color.Red;
            this.LbGameOver.Location = new System.Drawing.Point(0, 33);
            this.LbGameOver.Margin = new System.Windows.Forms.Padding(0);
            this.LbGameOver.Name = "LbGameOver";
            this.LbGameOver.Size = new System.Drawing.Size(222, 26);
            this.LbGameOver.TabIndex = 11;
            this.LbGameOver.Text = "Highest Score: ";
            this.LbGameOver.Visible = false;
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.BackColor = System.Drawing.Color.Transparent;
            this.LbScore.Font = new System.Drawing.Font("Hack NFM", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.ForeColor = System.Drawing.Color.Red;
            this.LbScore.Location = new System.Drawing.Point(222, 33);
            this.LbScore.Margin = new System.Windows.Forms.Padding(0);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(26, 26);
            this.LbScore.TabIndex = 12;
            this.LbScore.Text = "0";
            this.LbScore.Visible = false;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 95);
            this.Controls.Add(this.PnlContainer);
            this.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.PnlContainer.ResumeLayout(false);
            this.PnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Label LbGameOver;
        private System.Windows.Forms.Label LbScore;
    }
}