using System;
using System.Drawing;

namespace lab_1
{
    class Square : Shape
    {
        public Square(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness) { }

        public int Height
        {
            get
            {
                return Math.Abs(secondPoint.Y - firstPoint.Y);
            }
        }

        public Point topLeft
        {
            get
            {
                int x = Math.Min(firstPoint.X, secondPoint.X);
                int y = Math.Min(firstPoint.Y, secondPoint.Y);
                return new Point(x, y);
            }
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawRectangle(pen, topLeft.X, topLeft.Y, Height, Height);
        }
    }
}
