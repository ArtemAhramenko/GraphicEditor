using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    class RightTriangle : lab2.Shapes.Triangle
    {
        Point[] points;
        Point left, up, right;
        public RightTriangle(Pen pen, Point upLeft, Point downRigth) : base(pen, upLeft, downRigth)
        {


            if ((upLeft.X < downRigth.X) && (upLeft.Y < downRigth.Y))
            {
                up.X = upLeft.X;
                up.Y = upLeft.Y;
                left.X = upLeft.X;
                left.Y = downRigth.Y;
                right.X = downRigth.X;
                right.Y = downRigth.Y;
            }
            else if ((upLeft.X < downRigth.X) && (upLeft.Y > downRigth.Y))
            {
                up.X = upLeft.X;
                up.Y = downRigth.Y;
                left.X = upLeft.X;
                left.Y = upLeft.Y;
                right.X = downRigth.X;
                right.Y = upLeft.Y;
            }
            else if ((upLeft.X > downRigth.X) && (upLeft.Y < downRigth.Y))
            {
                up.X = downRigth.X;
                up.Y = upLeft.Y;
                left.X = downRigth.X;
                left.Y = downRigth.Y;
                right.X = upLeft.X;
                right.Y = downRigth.Y;
            }
            else if ((upLeft.X > downRigth.X) && (upLeft.Y > downRigth.Y))
            {
                up.X = downRigth.X;
                up.Y = downRigth.Y;
                left.X = downRigth.X;
                left.Y = upLeft.Y;
                right.X = upLeft.X;
                right.Y = upLeft.Y;
            }

            points = new Point[] { up, left, right };
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}

