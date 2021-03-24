using System.Drawing;

namespace lab_1
{
    class Line : Shape
    {
        public Line(Point firstPoint, Point secondPoint, Color color, int thickness) : base(firstPoint, secondPoint, color, thickness)
        {
        }


        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(pen, firstPoint, secondPoint);
        }
    }
}
