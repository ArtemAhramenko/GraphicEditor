using System;
using System.Drawing;

namespace GraphicEditor.Shapes
{
    class Square : Rectangle
    {
        public Square(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public override void Draw(Graphics graphics)
        {
            if ((firstPoint.X < secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                graphics.DrawRectangle(pen, firstPoint.X, firstPoint.Y, Math.Abs(secondPoint.X - firstPoint.X), Math.Abs(secondPoint.X - firstPoint.X));
            }
            else if ((firstPoint.X < secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                graphics.DrawRectangle(pen, firstPoint.X, firstPoint.Y - (firstPoint.Y - secondPoint.Y), Math.Abs(secondPoint.X - firstPoint.X), Math.Abs(secondPoint.X - firstPoint.X));
            }
            else if ((firstPoint.X > secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                graphics.DrawRectangle(pen, firstPoint.X - (firstPoint.X - secondPoint.X), firstPoint.Y - (firstPoint.Y - secondPoint.Y), Math.Abs(secondPoint.X - firstPoint.X), Math.Abs(secondPoint.X - firstPoint.X));
            }
            else
            {
                graphics.DrawRectangle(pen, firstPoint.X - (firstPoint.X - secondPoint.X), firstPoint.Y, Math.Abs(secondPoint.X - firstPoint.X), Math.Abs(secondPoint.X - firstPoint.X));
            }
        }
    }
}                         