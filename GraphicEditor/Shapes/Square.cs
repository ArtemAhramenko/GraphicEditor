using System;
using System.Drawing;

namespace GraphicEditor.Shapes
{
    class Square : Rectangle
    {
        public Square(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public override void Draw(Graphics graphics)
        {
            height = Math.Abs(secondPoint.X - firstPoint.X);
            CheckCondition(graphics, height, height);
        }
    }
}                         