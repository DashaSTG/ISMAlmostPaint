using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;
using LineLibrary;
using PointLibrary;
using CircleLibrary;
using EllipseLibrary;
using RectangleLibrary;

namespace WindowsFormsApp2
{
    public partial class OOPDrawing : Form
    {
        public OOPDrawing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shape[] shapes = new Shape[20];
            Random random = new Random();

            for(int i = 0; i < shapes.Length; i++)
            {
                if(random.Next(0, 5) == 0)
                {
                    shapes[i] = new PointLibrary.Point();
                }

                else if (random.Next(0, 5) == 1)
                {
                    shapes[i] = new Line();
                }

                else if (random.Next(0, 5) == 2)
                {
                    shapes[i] = new RectangleLibrary.Rectangle();
                }

                else if (random.Next(0, 5) == 3)
                {
                    shapes[i] = new Circle();
                }

                else if (random.Next(0, 5) == 4)
                {
                    shapes[i] = new Ellipse();
                }
            }
            
            for (int i = 0; i < shapes.Length; i++)
            {
               shapes[i].Draw(pictureBoxShapes.CreateGraphics());
            }
        }

        private void OOPDrawing_Load(object sender, EventArgs e)
        {

        }
    }
}
