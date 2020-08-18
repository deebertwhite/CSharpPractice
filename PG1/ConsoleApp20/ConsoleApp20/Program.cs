using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -3.97;
            double b = 0.11234;
            double c = 13.32;
            double d = -4.99999;

            Point p1 = new Point(a,b);

            Point p2 = new Point(d,c);

            Rectangle r1 = new Rectangle(p1, 5, 3);
            Console.WriteLine("Rectangle r1: Area = " + r1.GetArea());
            Console.WriteLine("Rectangle r1: Perimeter = " + r1.GetPerimeter());
            Console.WriteLine("Rectangle r1: Diagonal = " + r1.GetDiagonal());

            Rectangle r2 = new Rectangle(p2, 0.55, 9.73);
            Console.WriteLine("\n\n\nRectangle r2: Area = " + r2.GetArea());
            Console.WriteLine("Rectangle r2: Perimeter = " + r2.GetPerimeter());
            Console.WriteLine("Rectangle r2: Diagonal = " + r2.GetDiagonal());



            //double apart = p1.DistanceApart(p2);

            //Console.WriteLine("Point p1: x = " + p1.GetX() + ", y = " + p1.GetY());
            //Console.WriteLine("Point p2: x = " + p2.GetX() + ", y = " + p2.GetY());
            //Console.WriteLine("point p1 is " + apart + " units from point p2");

            //p2.SetX(c);
            //p2.SetY(d);


            //apart = p2.DistanceApart(p1);

            //Console.WriteLine("\n\nPoint p1: x = " + p1.GetX() + ", y = " + p1.GetY());
            //Console.WriteLine("Point p2: x = " + p2.GetX() + ", y = " + p2.GetY());
            //Console.WriteLine("point p2 is " + apart + " units from point p1");

            Console.ReadKey();
        }
    }
}
