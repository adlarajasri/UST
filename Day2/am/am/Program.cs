using System;


namespace am
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e= new Employee();
            Console.WriteLine("Employee id:");
            e.Empid=int.Parse(Console.ReadLine());
            Console.WriteLine("Employee name:");
            e.Empname=Console.ReadLine();
            Console.WriteLine("Employee salary");
            e.Empsalary=decimal.Parse(Console.ReadLine());

            Console.WriteLine(e.Empid);
            Console.WriteLine(e.Empname);
            Console.WriteLine(e.Empsalary);
        }
    }
}
