using System;


namespace circle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0, area;
            Console.WriteLine("Enter the Radius:");
            r = double.Parse(Console.ReadLine());
            area = CalcArea(r);
            Console.WriteLine("Area Of circle {0} is {1}", r, area);
        }
        static double CalcArea(double r)
        { 
            double area = 0.0;
            area = 3.14 * r*r;
            return area;
        }
    }
}
