using System.Drawing;

namespace GraphicEditor.Shapes
{
    class RightTriangle : GraphicEditor.Shapes.Triangle
    {
        Point[] points;
        Point left, up, right;
        public RightTriangle(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public override void Draw(Graphics graphics)
        {
            if ((firstPoint.X < secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                up.X = firstPoint.X;
                up.Y = firstPoint.Y;
                left.X = firstPoint.X;
                left.Y = secondPoint.Y;
                right.X = secondPoint.X;
                right.Y = secondPoint.Y;
            }
            else if ((firstPoint.X < secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                up.X = firstPoint.X;
                up.Y = secondPoint.Y;
                left.X = firstPoint.X;
                left.Y = firstPoint.Y;
                right.X = secondPoint.X;
                right.Y = firstPoint.Y;
            }
            else if ((firstPoint.X > secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                up.X = secondPoint.X;
                up.Y = firstPoint.Y;
                left.X = secondPoint.X;
                left.Y = secondPoint.Y;
                right.X = firstPoint.X;
                right.Y = secondPoint.Y;
            }
            else
            {
                up.X = secondPoint.X;
                up.Y = secondPoint.Y;
                left.X = secondPoint.X;
                left.Y = firstPoint.Y;
                right.X = firstPoint.X;
                right.Y = firstPoint.Y;
            }
            points = new Point[] { up, left, right };
            graphics.DrawPolygon(pen, points);
        }
    }
}

