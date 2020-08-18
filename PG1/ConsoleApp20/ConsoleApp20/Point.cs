using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Point
    {
        private double xPos;
        private double yPos;

        public Point()
        {
            xPos = 0;
            yPos = 0;
        }

        public Point(double x, double y)
        {
            xPos = x;
            yPos = y;
        }

        public double GetX()
        {
            return xPos;
        }

        public double GetY()
        {
            return yPos;
        }

        public void SetX(double barney)
        {
            xPos = barney;
        }

        public void SetY(double wilma)
        {
            yPos = wilma;
        }

        public double DistanceApart(Point p2)
        {
            double dist = 0;
            double x2 = p2.GetX();
            double y2 = p2.GetY();
            dist = Math.Sqrt(Math.Pow(x2 - xPos, 2) + Math.Pow(y2 - yPos, 2));

            return Math.Round(dist,3);
        }
    }
}
