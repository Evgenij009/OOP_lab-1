using System;
using System.Drawing;

namespace lab_1
{
    class Circle : Shape
    {
        public Circle(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness) { }

        public int Radius
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

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, Radius, Radius);
        }
    }
}
