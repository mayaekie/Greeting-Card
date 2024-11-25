using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen purplePen = new Pen(Color.DarkOrchid, 20);
            SolidBrush purpleBrush = new SolidBrush(Color.DarkOrchid);

            g.Clear(Color.White);
            g.DrawEllipse(purplePen, 85, 85, 175, 175);
            g.FillEllipse(purpleBrush, 85, 85, 175, 175);

            Graphics G = this.CreateGraphics();
            Pen brownPen = new Pen(Color.Brown, 10);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);

            
            G.DrawArc(brownPen,79, 78, 189, 189, 0, 180);
            G.DrawArc(brownPen, 78, 77, 189, 225, 0, 180);
            G.FillArc(brownBrush, 78, 77, 189, 225, 0, 180);


            Font drawFont2 = new Font("Arial", 30, FontStyle.Regular);
            SolidBrush drawBrush2 = new SolidBrush(Color.Red);
            g.DrawString("", drawFont2, drawBrush2, 95, 255);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
