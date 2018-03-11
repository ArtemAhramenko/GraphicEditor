using System.Drawing;

namespace GraphicEditor.Shapes
{
    class Line : Figure
    {
        public Line(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, firstPoint, secondPoint);
        }
    }
}