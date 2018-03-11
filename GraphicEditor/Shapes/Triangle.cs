using System;
using System.Drawing;

namespace GraphicEditor.Shapes
{
    class Triangle : Figure
    {
        Point[] points;
        Point left, up, right;
        public Triangle(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public override void Draw(Graphics graphics)
        {
            if ((firstPoint.X < secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                up.X = Math.Abs((firstPoint.X - secondPoint.X) / 2) + firstPoint.X;
                up.Y = firstPoint.Y;
                left.X = firstPoint.X;
                left.Y = secondPoint.Y;
                right.X = secondPoint.X;
                right.Y = secondPoint.Y;
            }
            else if ((firstPoint.X < secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                up.X = Math.Abs((firstPoint.X - secondPoint.X) / 2) + firstPoint.X;
                up.Y = secondPoint.Y;
                left.X = firstPoint.X;
                left.Y = firstPoint.Y;
                right.X = secondPoint.X;
                right.Y = firstPoint.Y;
            }
            else if ((firstPoint.X > secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                up.X = firstPoint.X - Math.Abs((firstPoint.X - secondPoint.X) / 2);
                up.Y = firstPoint.Y;
                left.X = secondPoint.X;
                left.Y = secondPoint.Y;
                right.X = firstPoint.X;
                right.Y = secondPoint.Y;
            }
            else
            {
                up.X = firstPoint.X - Math.Abs((firstPoint.X - secondPoint.X) / 2);
                up.Y = secondPoint.Y;
                left.X = secondPoint.X;
                left.Y = firstPoint.Y;
                right.X = firstPoint.X;
                right.Y = firstPoint.Y;
            }
            points = new Point[] { left, up, right };
            graphics.DrawPolygon(pen, points);
        }
    }
}