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
            this.Width = 500;
            this.Height = 500;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen bluePen = new Pen(Color.DarkBlue);                  //paints the exterior (outline)
            Brush blueBrush = new SolidBrush(Color.DarkBlue);       //paints the interior (fills in)
            Pen skyPen = new Pen(Color.LightSkyBlue);
            Brush skyBrush = new SolidBrush(Color.LightSkyBlue);
            Pen brownPen = new Pen(Color.BurlyWood);
            Brush brownBrush = new SolidBrush(Color.BurlyWood);


            g.Clear(Color.White);
            g.DrawRectangle(bluePen, 0, 0, 500, 275);
            g.FillRectangle(blueBrush, 0, 0, 500, 275);

            g.DrawEllipse(skyPen, 140, 55, 200, 200);
            g.FillEllipse(skyBrush, 140, 55, 200, 200);

            //create points that define a polygon
            Point point1 = new Point(140,325);
            Point point2 = new Point(190, 255);
            Point point3 = new Point(290, 255);
            Point point4 = new Point(340, 325);
            Point[] curvePoints =
                {
                    point1,
                    point2,
                    point3,
                    point4
                };

            g.DrawPolygon(brownPen, curvePoints);
            g.FillPolygon(brownBrush, curvePoints);



        }
    }
}
