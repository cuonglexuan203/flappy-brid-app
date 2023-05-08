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
        bool paused = false;
        //
        Point mouseOffset;
        int gravity = 5;
        int pipeSpeed = 5;
        int score = 0;
        //
        //
        Random random = new Random();
        static Point birdStart = new Point(90, 314);
        static Point pipeDownStart = new Point(327,-165);
        static Point pipeUpStart = new Point(299, 408);
        //
        UserData userData;

        //
        public AppForm()
        {

            InitializeComponent();
        }
        private void AppForm_Load(object sender, EventArgs e)
        {
            CustomizeUI();
            this.LbScore.Text = score.ToString();
            //
            userData = new UserData();

        }
        private void Handler_StartingGame()
        {
            this.LbInstructionStart.Hide();
            this.LbGameOver.Hide();
            this.PBPipeUp.Location = pipeUpStart;
            this.PBPipeDown.Location = pipeDownStart;
            this.PBBird.Location = birdStart;
            this.pipeSpeed = 5;
            this.pipeTimer.Interval = 30;
            this.score = 0;
            //
            //
            started = true;
            mainTimer.Start();
            pipeTimer.Start();
        }
        // starting game
        private void AppForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!started)
            {
                e.Handled = true;
                //
                Thread.Sleep(200);
                Handler_StartingGame();
            }
        }
        private void AppForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (started && (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up))
            {
                e.Handled = true;
                this.gravity = 3;
                this.PBBird.Image = global::FlappyBirdApp.Properties.Resources.bird_down;
            }
        }

        private void AppForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (started)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    e.Handled = true;
                    if (paused)
                    {
                        ContinueGamePlay();
                    }
                    this.gravity = -10;
                    this.PBBird.Image = global::FlappyBirdApp.Properties.Resources.bird_up3;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    PauseGamePlay();
                }
                
            }
            
        }
        //
        private void TxtTitle_MouseDown(object sender, MouseEventArgs e)
        {
            PnlContainer.Focus();
        }

        private void Handler_FormBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(16, 117, 194);
        }
        private void PauseGamePlay()
        {
            this.mainTimer.Stop();
            this.pipeTimer.Stop();
            paused = true;
        }
        private void ContinueGamePlay()
        {
            this.mainTimer.Start();
            this.pipeTimer.Start();
            paused = false;
        }
        private void Handler_FormBtn_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn.Tag.ToString() == "exit")
            {
                if (started)
                {
                    this.mainTimer.Stop();
                    this.pipeTimer.Stop();
                    DialogResult result = MessageBox.Show("Are you sure?", "Flappy Bird", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        this.mainTimer.Start();
                        this.pipeTimer.Start();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (btn.Tag.ToString() == "minimize")
            {

                PauseGamePlay();
                this.WindowState = FormWindowState.Minimized;
                this.PnlMain.Focus();
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

        private void Handler_GameOver()
        {
            if (this.PBBird.Bounds.IntersectsWith(PBPipeUp.Bounds) || this.PBBird.Bounds.IntersectsWith(PBPipeDown.Bounds)
                || this.PBBird.Bounds.IntersectsWith(PBGround.Bounds))
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            this.userData.Score = (this.userData.Score < score) ? score : this.userData.Score;
            //
            started = false;
            this.mainTimer.Stop();
            this.pipeTimer.Stop();
            this.LbGameOver.Show();
            this.LbInstructionStart.Show();
        }
        //
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            this.PBBird.Top += gravity;
            //
            Handler_GameOver();
        }
        private void ProcessLevel()
        {
            if (score == 10 || score == 9) // level 1
            {
                pipeTimer.Interval = 15;
            }
            else if (score == 26 || score == 25) // level 2
            {
                pipeTimer.Interval = 5;
                pipeSpeed = 6;
            }
            else if (score == 40 || score == 39) // level 3
            {
                pipeTimer.Interval = 1;
                pipeSpeed = 8;
            }
            else if (score == 70 || score == 69) // level 4
            {
                pipeSpeed = 10;
            }
            else if (score == 100 || score == 99) // level 5
            {
                pipeSpeed = 12;
            }
            else if (score == 150 || score == 149) // level 6
            {
                pipeSpeed = 15;
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
                int top = -this.PBPipeDown.Height +  random.Next(this.PBPipeDown.Height / 3, this.PnlMain.Height / 2 - this.PBBird.Height) ;
                this.PBPipeDown.Top = top;
            }

            if (PBPipeUp.Right <= 0)
            {
                int left = this.Width + random.Next(0, this.Width/2 - PBPipeUp.Width) ;
                PBPipeUp.Left = left;
                passedPipeUp = false;
                //
                int top = PnlMain.Height  - random.Next(this.PBPipeUp.Height / 3 + PBGround.Height, this.PnlMain.Height / 2 - this.PBBird.Height) ;
                this.PBPipeUp.Top = top;
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

            //
            ProcessLevel();

        }
    }
}
