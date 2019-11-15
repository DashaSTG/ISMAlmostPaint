using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
   public class Line : Point
    {
        protected int CoordX2;
        protected int CoordY2;

        public Line(int coordX1, int coordY1, int coordX2, int coordY2, Pen pen) : base(coordX1, coordY1, pen)
        {
            CoordX2 = coordX2;
            CoordY2 = coordY2;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, CoordX1, CoordY1, CoordX2, CoordY2);
        }

        public override void Move(int detX, int detY)
        {
            base.Move(detX, detY);
            CoordX2 += detX;
            CoordY2 += detY;
        }
    }
}
