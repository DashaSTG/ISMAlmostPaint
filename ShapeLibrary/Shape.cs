using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        protected Pen Pen;
        protected int CoordX1;
        protected int CoordY1;

        public Shape(int coordX1, int coordY1, Pen pen)
        {
            CoordX1 = coordX1;
            CoordY1 = coordY1;
            Pen = pen;
        }

        public abstract void Draw(Graphics graphics);

        public abstract void Move(int detX, int DetY);
    }
}
