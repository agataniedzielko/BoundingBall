using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                g.DrawEllipse(Pens.Red, 100, 100, 50, 50);

            }//
        }


        int x = 0;
        int y = 0;
        //int old_x = 0;
        //int old_y = 0;
        int krokx = 1;
        int kroky = 1;

        Bitmap b = new Bitmap(5000,5000);

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == null)
                {
                    b = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
                }
            using (var g = Graphics.FromImage(b))
            {
                g.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

                g.FillEllipse(Brushes.Green, 100, 100, 100, 100);
                g.FillRectangle(Brushes.Yellow, 250, 110, 50, 50);
                g.FillEllipse(Brushes.Violet, 300, 300, 300, 420);
                g.FillRectangle(Brushes.Pink, 250, 200, 150, 50);
                //g.DrawEllipse(SystemPens.Control, old_x, old_y, 50, 50);
                g.FillEllipse(Brushes.Blue, x, y, 50, 50);
                //old_x = x;
                //old_y = y;
                
                x+=krokx;
                if ((x <= 0) || (( x ) >= (this.ClientRectangle.Width - 50)) )
                {
                    krokx = -krokx;  
                }

                y += kroky;
                if ((y <= 0) || (( y ) >= (this.ClientRectangle.Height - 50)))
                {
                    kroky = -kroky;
                }

               

            }//
            
            

            using (Graphics gg = CreateGraphics())
            {
                gg.DrawImageUnscaled(b, 0, 0);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
         if (e.KeyCode == Keys.Up)
            {
                krokx += Math.Sign(krokx) * 1;
                
            }
         if (e.KeyCode == Keys.Down)
            {
                krokx -= Math.Sign(krokx) * 1;
            }
         if (e.KeyCode == Keys.Left)
            {
                kroky -= Math.Sign(kroky) * 1;
            }
         if (e.KeyCode == Keys.Right)
            {
                
                kroky += Math.Sign(kroky) * 1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
