using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaternumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());
            int result = absoutedifference(n);
            Console.WriteLine("THE RESULT = {0}", result);

        }


        static int absoutedifference(int n)
        { 
            if (n > 51)
            {
                int res = (n - 51) * 3;
                return res; 
            }
            else
            {
                int res1 = (51 - n);
                return res1;
            }

        }
    }
}
