using System.Drawing;

namespace lab_1
{
    class Ellipse : Rectangle
    {
        public Ellipse(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness) { }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, Width, Height);
        }
    }
}
