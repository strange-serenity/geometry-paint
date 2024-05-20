using System;
using System.Drawing;

namespace WindowsFormsApp2
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics g);
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Circle(int radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; }

        public Rectangle(int width, int height, Point location)
        {
            Width = width;
            Height = height;
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Red, Location.X, Location.Y, Width, Height);
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    public class Diamond : Shape
    {
        public Point Center { get; set; }
        public int HorizontalDiagonal { get; set; }
        public int VerticalDiagonal { get; set; }

        public Diamond(Point center, int horizontalDiagonal, int verticalDiagonal)
        {
            Center = center;
            HorizontalDiagonal = horizontalDiagonal;
            VerticalDiagonal = verticalDiagonal;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = new Point[4];
            points[0] = new Point(Center.X, Center.Y - VerticalDiagonal / 2);
            points[1] = new Point(Center.X + HorizontalDiagonal / 2, Center.Y);
            points[2] = new Point(Center.X, Center.Y + VerticalDiagonal / 2);
            points[3] = new Point(Center.X - HorizontalDiagonal / 2, Center.Y);
            g.DrawPolygon(Pens.Red, points);
        }

        public override double CalculateArea()
        {
            return (HorizontalDiagonal * VerticalDiagonal) / 2.0;
        }
    }
    public class Triangle : Shape
    {
        public int SideLength { get; set; }
        public Point Center { get; set; }

        public Triangle(int sideLength, Point center)
        {
            SideLength = sideLength;
            Center = center;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = GetVertices();
            g.DrawPolygon(Pens.Red, points);
        }

        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * SideLength * SideLength;
        }

        private Point[] GetVertices()
        {
            float height = (float)(Math.Sqrt(3) / 2 * SideLength);
            Point p1 = new Point(Center.X, Center.Y - (int)(2.0 / 3.0 * height));
            Point p2 = new Point(Center.X - SideLength / 2, Center.Y + (int)(1.0 / 3.0 * height));
            Point p3 = new Point(Center.X + SideLength / 2, Center.Y + (int)(1.0 / 3.0 * height));
            return new Point[] { p1, p2, p3 };
        }
    }

}