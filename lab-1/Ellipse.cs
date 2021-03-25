using System;
using System.Drawing;

namespace lab_1
{
    class Ellipse : Circle
    {
        public Ellipse(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness) { }

        public int SecondRadius
        {
            get
            {
                return Math.Abs(secondPoint.X - firstPoint.X);
            }
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, SecondRadius, Radius);
        }
    }
}
