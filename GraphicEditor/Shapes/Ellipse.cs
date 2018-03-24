using System;
using System.Drawing;

namespace GraphicEditor.Shapes
{
    class Ellipse : Figure
    {
        public Ellipse(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }
        public int width { get; set; }
        public int height { get; set; }


        public override void Draw(Graphics graphics)
        {
            width = Math.Abs(secondPoint.X - firstPoint.X);
            height = Math.Abs(secondPoint.Y - firstPoint.Y);
            CheckCondition(graphics, width, height);
        }

        public void CheckCondition(Graphics graphics, int width, int height)
        {
            if ((firstPoint.X < secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                graphics.DrawEllipse(pen, firstPoint.X, firstPoint.Y, width, height);
            }
            else if ((firstPoint.X < secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                graphics.DrawEllipse(pen, firstPoint.X, secondPoint.Y, width, height);
            }
            else if ((firstPoint.X > secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                graphics.DrawEllipse(pen, secondPoint.X, secondPoint.Y, width, height);
            }
            else
            {
                graphics.DrawEllipse(pen, secondPoint.X, firstPoint.Y, width, height);
            }
        }
    }
}