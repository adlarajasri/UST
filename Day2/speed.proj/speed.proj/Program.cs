﻿using System;
namespace speed.proj
{
    class Program
    {
        static void Main(string[] args)
        {
            double t, d, s;
            Console.WriteLine("Enter time in hours:");
            t=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the distance in kilometers:");
            d=double.Parse(Console.ReadLine()); 
            s=speed(t,d);
            Console.WriteLine("speed in kilometer per hour:" + s + "kph");
            Console.WriteLine("speed in miles per hour:" + (1.609344 * s) + "mph");

        }
        static double speed(double t, double d)
        {
            double s = 0;   
            s = d / t;
            return s;
        }
    }
}
