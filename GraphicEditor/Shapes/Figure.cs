using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Shapes
{
    abstract class Figure
    {
        public Point upLeft, downRigth;
        public Pen pen = new Pen(Color.Green, 3);
        public Figure(Point upLeft, Point downRigth){
            this.upLeft = upLeft;
            this.downRigth = downRigth;
        }
        public abstract void Draw(Graphics graphics);
    }
}
