using System;
using System.Drawing;

namespace GraphicEditor.Shapes
{
    class Circle : Ellipse
    {
        public Circle(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public override void Draw(Graphics graphics)
        {
            width = Math.Abs(secondPoint.X - firstPoint.X);
            CheckCondition(graphics, width, width);
        }
    }
}