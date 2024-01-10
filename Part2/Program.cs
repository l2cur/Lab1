
using System.Numerics;
using static System.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Program
    {
        static void Main()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(6, -4);
            Point p3 = new Point(1, 12);
            Point p4 = new Point(21, 23);
            Point p5 = new Point(32, 12);

            Figure f1 = new Figure(p1, p2, p3);
            Figure f2 = new Figure(p1, p4, p3, p5);
            Figure f3 = new Figure(p1, p2, p3, p4, p5);

            f1.Name = "triangle";
            f2.Name = "quadrilateral";
            f3.Name = "pentagon";

            Console.Write($"1. This figure is {f1.Name} and its perimeter is ");
            f1.PerimeterCalculator();
            Console.Write($"2. This figure is {f2.Name} and its perimeter is ");
            f2.PerimeterCalculator();
            Console.Write($"3. This figure is {f3.Name} and its perimeter is ");
            f3.PerimeterCalculator();
        }
    }

    public class Figure
    {
        Point p1, p2, p3;
        Point p4, p5;

        public string Name
        { get; set; }

        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
        {
            this.p4 = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
        {
            this.p5 = p5;
        }

        public double LengthSide(Point A, Point B)
        {
            return Sqrt(Pow((A.x - B.x), 2) + Pow((A.y - B.y), 2));
        }

        public void PerimeterCalculator()
        {
            double prm = 0;

            if (this.p5 != null)
            {
                prm = (LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p1, p5));
                Console.WriteLine($"{prm: .##}");
                return;
            }

            if (this.p4 != null)
            {
                prm = (LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p1, p4));
                Console.WriteLine($"{prm: .##}");
                return;
            }

            prm = (LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p1, p3));
            Console.WriteLine($"{prm: .##}");
            return;
        }

    }
    public class Point
    {
        int X, Y;

        public int x
        {
            get
            {
                return X;
            }
        }

        public int y
        {
            get
            {
                return Y;
            }
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}