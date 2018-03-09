using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lab2.Shapes;

namespace lab2
{
    class Rectangle : Figure
    {
        public int sizeX, sizeY;
        public Rectangle(Point upLeft, Point size) : base(upLeft, new Point())
        {
            sizeX = size.X;
            sizeY = size.Y;
        }
        public override void Draw(Graphics graphics)
        {
            if ((upLeft.X < sizeX) && (upLeft.Y < sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X, upLeft.Y, Math.Abs(sizeX - upLeft.X), Math.Abs(sizeY - upLeft.Y));
            }
            else if ((upLeft.X < sizeX) && (upLeft.Y > sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X, upLeft.Y - (upLeft.Y - sizeY), Math.Abs(sizeX - upLeft.X), Math.Abs(sizeY - upLeft.Y));
            }
            else if ((upLeft.X > sizeX) && (upLeft.Y > sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X - (upLeft.X - sizeX), upLeft.Y - (upLeft.Y - sizeY), Math.Abs(sizeX - upLeft.X), Math.Abs(sizeY - upLeft.Y));
            }
            else if ((upLeft.X > sizeX) && (upLeft.Y < sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X - (upLeft.X - sizeX), upLeft.Y, Math.Abs(sizeX - upLeft.X), Math.Abs(sizeY - upLeft.Y));
            }
        }
    }
}