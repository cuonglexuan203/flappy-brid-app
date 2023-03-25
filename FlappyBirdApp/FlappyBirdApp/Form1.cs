using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdApp
{
    public partial class AppForm : Form
    {
        // Control
        bool started = false;
        bool passedPipeUp = false;
        bool passedPipeDown = false;
        //
        Point mouseOffset;
        int gravity = 5;
        int pipeSpeed = 5;
        int score = 0;
        //
        //
        Random random = new Random();
        static Point birdStart = new Point(90, 314);
        static Point pipeDownStart = new Point(314,-117);
        static Point pipeUpStart = new Point(311, 426);




        //
        public AppForm()
        {
            InitializeComponent();
        }

        private void TxtTitle_MouseDown(object sender, MouseEventArgs e)
        {
            PnlContainer.Focus();
        }

        private void Handler_FormBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(16, 117, 194);
        }

        private void Handler_FormBtn_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn.Tag.ToString() == "exit")
            {
                if (started)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Flappy Bird", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (btn.Tag.ToString() == "minimize")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            
        }

        private void Handler_FormBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(0, 108, 190);
        }

        private void Handler_FormBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(43, 43, 43);
            btn.BackColor = Color.Transparent;

        }

        private void Handler_FormBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(43, 43, 43);
        }


        private void Handler_SetMouseOffset(object sender, MouseEventArgs e)
        {
            mouseOffset = new Point(-e.X, -e.Y);
        }

       

        private void Handler_MovingForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                Point pos = Control.MousePosition;
                pos.Offset(mouseOffset);
                this.Location = pos;

            }
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.LbScore.Text = score.ToString();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            this.PBBird.Top += gravity;
            //
            if (this.PBBird.Bounds.IntersectsWith(PBPipeUp.Bounds) || this.PBBird.Bounds.IntersectsWith(PBPipeDown.Bounds)
                || this.PBBird.Bounds.IntersectsWith(PBGround.Bounds))
            {
                started = false;
                this.mainTimer.Stop();
                this.pipeTimer.Stop();
                this.LbGameOver.Show();
                this.LbInstructionStart.Show();
            }
        }

        private void AppForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (started)
            {
                e.Handled = true;
                this.gravity = -10;
            }
        }

        private void AppForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (started)
            {
                e.Handled = true;
                this.gravity = 3;
            }
        }

        private void AppForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!started)
            {
                e.Handled = true;
                //
                Thread.Sleep(200);
                this.LbInstructionStart.Hide();
                this.LbGameOver.Hide();
                this.PBPipeUp.Location = pipeUpStart;
                this.PBPipeDown.Location = pipeDownStart;
                this.PBBird.Location = birdStart;

                //
                started = true;
                mainTimer.Start();
                pipeTimer.Start();
            }
        }

        private void pipeTimer_Tick(object sender, EventArgs e)
        {
            this.PBPipeUp.Left -= pipeSpeed;
            this.PBPipeDown.Left -= pipeSpeed;
            this.LbScore.Text = score.ToString();
            //
            if (PBPipeDown.Right <= 0)
            {
                passedPipeDown = false;
                int left = this.Width + random.Next(0, this.Width / 2 - PBPipeDown.Width) ;
                PBPipeDown.Left = left;
                //
                int top = -this.PBPipeDown.Height +  random.Next(0, this.Height / 2);
                this.PBPipeDown.Top = top;
            }

            if (PBPipeUp.Right <= 0)
            {
                int left = this.Width + random.Next(0, this.Width/2 - PBPipeUp.Width) ;
                PBPipeUp.Left = left;
                passedPipeUp = false;
                //
                this.PBPipeUp.Top = this.PBPipeDown.Bottom + 53 * 2 + random.Next(35, 70);
            }


            //
            if (PBPipeUp.Right <= PBBird.Left && !passedPipeUp)
            {
                passedPipeUp = true;
                score += 1;
            }
            if (PBPipeDown.Right <= PBBird.Left && !passedPipeDown)
            {
                passedPipeDown = true;
                score += 1;
            }

        }
    }
}
