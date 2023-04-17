using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace MyNamespace
{
    class circle
    {
        static void Main(string[] args)
        {
            double r = 0.0, area;
            Console.WriteLine(" enter the radius:");
            r = double.Parse(Console.ReadLine());
            area = CalcArea(r);
            Console.WriteLine("Area of circle having radius {0} is {1}", r, area);

        }


        static double CalcArea(double r)
        {
            double area = 0.0;
            area = 3.14 * r * r;
            return area;
        }
    }
}
