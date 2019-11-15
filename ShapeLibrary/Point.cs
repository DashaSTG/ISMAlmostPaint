using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public class Point : Shape
    {
        public Point(int coordX1, int coordY1, Pen pen) : base(coordX1, coordY1, pen)
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, CoordX1-1, CoordY1-1, 1, 1);
        }

        public override void Move(int detX, int detY)
        {
            CoordX1 += detX;
            CoordY1 += detY;
        }
    }
}
