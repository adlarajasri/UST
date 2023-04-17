using System;


namespace am
{
    class Employee
    {
        public int Empid;
        public string Empname;
        public decimal Empsalary;

        public Employee() //zero arguments
        { 
        
        }

        public Employee(int empid, string empname,decimal empsalary) //parameterised constructor
        {
            Empid=empid;
            Empname=empname;
            Empsalary = empsalary;
        }

    }
}
