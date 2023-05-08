using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdApp
{
    public partial class AppForm
    {

        //
        private void HideControls(List<Control> ctr) // initial hide
        {
            foreach (Control c in ctr)
            {
                c.Hide();
            }
        }
        //
        private void CustomizeUI()
        {
            DrawRectangleFrame(this);
            HideControls(new List<Control> { this.PnlShow, this.LbCountDown});
        }
        private void DrawRectangleFrame(Control ctr) 
        {
            Bitmap bm = new Bitmap(ctr.Width, ctr.Height);  
            Graphics g = Graphics.FromImage(bm);
            g.DrawRectangle(new Pen(Color.FromArgb(69, 69, 69)), new Rectangle(0 , 0, ctr.Width - 1, ctr.Height - 1));
            ctr.BackgroundImage = bm;
        }

    }
}
