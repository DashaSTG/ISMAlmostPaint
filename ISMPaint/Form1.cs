using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeLibrary;

namespace ISMPaint
{
    public partial class FormPaint : Form
    {
        protected List<Shape> Shapes;
        protected Mode Mode;
        protected int MouseX, MouseY, MouseX2, MouseY2;

        public void AddShapes(Shape shape)
        {
            Shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBoxMain.Refresh();
        }

        public void DeleteShape(int number)
        {
            Shapes.RemoveAt(number);
            listBoxShapes.Items.RemoveAt(number);
            pictureBoxMain.Refresh();
        }

        public FormPaint()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
            }
        }

        private void FormPaint_Load(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Black;
            Shapes = new List<Shape>();
            Mode = Mode.DrawPoint;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            AddShapes(new ShapeLibrary.Point(100, 100, new Pen(buttonColor.BackColor, 2)));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxShapes.Items.Count; i++)
            {
                if (listBoxShapes.GetSelected(i))
                {
                    DeleteShape(i);
                    i--;
                }
            }

            if(listBoxShapes.Items.Count > 0)
            {
                listBoxShapes.SetSelected(0, true);
            }
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i<Shapes.Count; i++)
            {
                Shapes[i].Draw(e.Graphics);
            }

            switch (Mode)
            {
                case Mode.DrawLine:
                    e.Graphics.DrawLine(new Pen(buttonColor.BackColor, 2), MouseX, MouseY, MouseX2, MouseY2);
                    break;
                case Mode.DrawRectangle:
                    e.Graphics.DrawRectangle(new Pen(buttonColor.BackColor, 2), MouseX, MouseY, MouseX2-MouseX, MouseY2-MouseY);
                    break;
                case Mode.DrawEllipse:
                    e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, 2), MouseX, MouseY, MouseX2 - MouseX, MouseY2 - MouseY);
                    break;
            }
            
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawPoint;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawRectangle;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    ShapeLibrary.Point point = new ShapeLibrary.Point(e.X, e.Y, new Pen(buttonColor.BackColor, 2));
                    AddShapes(point);
                    break;
                case Mode.DrawLine:
                case Mode.DrawCircle:
                case Mode.DrawRectangle:
                case Mode.DrawEllipse:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;

            }
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                    Shape line = new Line(MouseX, MouseY, e.X, e.Y, new Pen(buttonColor.BackColor, 2));
                    AddShapes(line);
                    break;
                case Mode.DrawCircle:
                    Shape circle = new Circle((e.X + MouseX) / 2, (e.Y + MouseY) / 2,
                           (int)Math.Sqrt(Math.Pow((e.X - MouseX), 2) + Math.Pow((e.Y - MouseY), 2)), new Pen(buttonColor.BackColor, 2));
                    AddShapes(circle);
                    break;
                case Mode.DrawRectangle:
                    Shape rectangle = new ShapeLibrary.Rectangle(MouseX, MouseY, e.X - MouseX, e.Y-MouseY, new Pen(buttonColor.BackColor, 2));
                    AddShapes(rectangle);
                    break;
                case Mode.DrawEllipse:
                    Shape ellipse = new Ellipse((e.X + MouseX) / 2, (e.Y + MouseY) / 2, e.X - MouseX, e.Y - MouseY, new Pen(buttonColor.BackColor, 2));
                    AddShapes(ellipse);
                    break;
            }

        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                case Mode.DrawRectangle:
                case Mode.DrawCircle:
                case Mode.DrawEllipse:
                    if (e.Button == MouseButtons.Left)
                    {
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        pictureBoxMain.Refresh();       
                    }                   
                    break;      
            }

        }
    }
}
