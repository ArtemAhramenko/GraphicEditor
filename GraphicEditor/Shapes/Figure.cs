using System.Drawing;

namespace GraphicEditor.Shapes
{
    abstract class Figure
    {
        public Point firstPoint, secondPoint;
        public Pen pen = new Pen(Color.Green, 3);
        public Figure(Pen pen, Point firstPoint, Point secondPoint)
        {
            this.pen = pen;
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
        }

        public abstract void Draw(Graphics graphics);
    }
}
