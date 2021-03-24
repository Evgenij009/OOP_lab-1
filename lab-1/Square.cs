using System.Drawing;

namespace lab_1
{
    class Square : Rectangle
    {
        public Square(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness) { }

        public override int Width
        {
            get
            {
                return Height;
            }
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawRectangle(pen, topLeft.X, topLeft.Y, Width, Width);
        }
    }
}
