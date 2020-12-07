using System;
using System.Drawing;

namespace Week11_BallEx
{
    class Ball
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius { get; private set; }
        public Color BallColour { get; private set; }
        public Ball(int x1, int y1, int radius, Color color)
        {
            X = x1;
            Y = y1;
            Radius = radius;
            BallColour = color;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(BallColour);
            g.FillEllipse(b, X, Y, Radius * 2, Radius * 2);
        }
        public bool PointInBall(int x, int y)
        {
            double cx = X + Radius;
            double cy = Y + Radius;
            double distance = Math.Sqrt(Math.Pow((cx - x), 2) + Math.Pow((cy - y), 2));
            return distance <= Radius;
        }

    }
}
