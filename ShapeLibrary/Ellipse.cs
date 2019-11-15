using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public class Ellipse : Circle
    {
        protected int Radius2;

        public Ellipse(int coordX1, int coordY1, int radius1, int radius2, Pen pen) : base(coordX1, coordY1, radius1, pen)
        {
            Radius2 = radius2;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, CoordX1 - Radius1 / 2, CoordY1 - Radius2 / 2, Radius1, Radius2);
        }
    }
}
