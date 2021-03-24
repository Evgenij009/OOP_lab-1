using System.Drawing;

namespace lab_1
{
    public abstract class Shape : IDraw
    {
        public Point firstPoint;
        public Point secondPoint;
        public Pen pen { get; set; }

        public Shape(Point firstPoint, Point secondPoint, Color color, int thickness)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.pen = new Pen(color, thickness);
        }

        public abstract void Draw(Graphics graphic);
    }

    interface IDraw
    {
        Pen pen { get; set; }
        void Draw(Graphics graphic);
    }
}
