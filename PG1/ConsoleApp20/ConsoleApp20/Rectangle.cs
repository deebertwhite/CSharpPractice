using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Rectangle
    {
        private Point topLeft;
        private double width;
        private double height;

        public Rectangle()
        {
            topLeft = new Point();
            width = 1;
            height = 1;
        }

        public Rectangle(Point tl, double w, double h)
        {
            topLeft = tl;
            width = w;
            height = h;
        }

        public Point GetTopLeft()
        {
            return topLeft;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetTopLeft(Point p)
        {
            topLeft = p;
        }

        public void SetWidth(double w)
        {
            width = w;
        }

        public void SetHeight(double h)
        {
            height = h;
        }

        public double GetArea()
        {
            double area = height * width;
            return Math.Round(area,2);
        }

        public double GetPerimeter()
        {
            double perimeter = (height * 2) + (width * 2);
            return Math.Round(perimeter, 3);
        }

        public double GetDiagonal()
        {
            double x = topLeft.GetX();
            double y = topLeft.GetY();

            double brX = Math.Abs(x + width);
            double brY = Math.Abs(y + height);
            Point bottomRight = new Point(brX, brY);

            double diagonal = topLeft.DistanceApart(bottomRight);
            return diagonal;
        }
    }
}
