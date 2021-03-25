using System;
using System.Drawing;

namespace lab_1
{
    class Rectangle : Square
    {

        public Rectangle(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness) { }

        public virtual int Width
        {
            get
            {
                return Math.Abs(secondPoint.X - firstPoint.X);
            }
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawRectangle(pen, topLeft.X, topLeft.Y, Width, Height);
        }
    }
}
