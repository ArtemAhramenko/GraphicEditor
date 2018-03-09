using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lab2.Shapes;

namespace lab2.Shapes
{
    class Line : Figure
    {
        public Point begin, end;
        public Line(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
            this.begin = begin;
            this.end = end;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, begin, end);
        }
    }
}
