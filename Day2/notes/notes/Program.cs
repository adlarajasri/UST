//write a program to enter an amount and find out number of notes required to make that amount
using System;
namespace notes
{
     class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8;
            int amount;
            Console.WriteLine("Enter the amount\n");
            amount=int.Parse(Console.ReadLine());

           while(amount > 0)
            {
                n1 = amount / 2000;
                amount = amount % 2000;
                n2 = amount / 500;
                amount = amount % 500;
                n3 = amount / 200;
                amount = amount % 200;
                n4 = amount / 100;
                amount = amount % 100;
                n5 = amount / 50;
                amount = amount % 50;
                n6 = amount / 20;
                amount = amount % 20;
                n7 = amount / 10;
                amount = amount % 10;
                n8 = amount / 5;
                amount = amount % 5;
                Console.WriteLine(n1 + "2000");
                Console.WriteLine(n1 + "500");
                Console.WriteLine(n1 + "200");
                Console.WriteLine(n1 + "100");
                Console.WriteLine(n1 + "50");
                Console.WriteLine(n1 + "20");
                Console.WriteLine(n1 + "10");
                Console.WriteLine(n1 + "5");
            }
       

        }
    }
}
