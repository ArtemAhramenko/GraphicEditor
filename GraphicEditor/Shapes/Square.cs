using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Square : Rectangle
    {
        public Square(Point upLeft, Point size) : base(upLeft, size)
        {
            this.upLeft = upLeft;
        }

        public override void Draw(Graphics graphics)
        {
            if ((upLeft.X < sizeX) && (upLeft.Y < sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X, upLeft.Y, Math.Abs(sizeX - upLeft.X), Math.Abs(sizeX - upLeft.X));
            }
            else if ((upLeft.X < sizeX) && (upLeft.Y > sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X, upLeft.Y - (upLeft.Y - sizeY), Math.Abs(sizeX - upLeft.X), Math.Abs(sizeX - upLeft.X));
            }
            else if ((upLeft.X > sizeX) && (upLeft.Y > sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X - (upLeft.X - sizeX), upLeft.Y - (upLeft.Y - sizeY), Math.Abs(sizeX - upLeft.X), Math.Abs(sizeX - upLeft.X));
            }
            else if ((upLeft.X > sizeX) && (upLeft.Y < sizeY))
            {
                graphics.DrawRectangle(pen, upLeft.X - (upLeft.X - sizeX), upLeft.Y, Math.Abs(sizeX - upLeft.X), Math.Abs(sizeX - upLeft.X));
            }
        }
    }
}