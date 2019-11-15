using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public class Rectangle : Line
    {
        public Rectangle(int coordX1, int coordY1, int coordX2, int coordY2, Pen pen) : base(coordX1, coordY1, coordX2, coordY2,  pen)
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pen, CoordX1, CoordY1, CoordX2, CoordY2);
        }
    }
}
