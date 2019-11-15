using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
   public class Circle : Point
    {
        protected int Radius1;

        public Circle(int coordX1, int coordY1, int radius1, Pen pen) : base(coordX1, coordY1, pen)
        {
            Radius1 = radius1;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, CoordX1 - Radius1/2, CoordY1 - Radius1/2, Radius1, Radius1);
        }


    }
}
