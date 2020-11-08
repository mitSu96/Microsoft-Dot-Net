using System;

namespace Emp_Lib
{
    public class Employee
    {
        static Employee()                //bank name to be dispalyed as soon as app is called and only once
        {
            Console.WriteLine("Starting The Employee Application\n\n\n");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\n****************Corporation Of Open-Source*****************\n");
            Console.WriteLine("--------------------------------------------------------------\n");

        }
        static int id_Def = 1;
        int id;
        string name;
        double salary,Net_Salary;
        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
            calculate_netsalary();
        }

        void calculate_netsalary()
        {
            Net_Salary = salary - (salary * 0.1);
        }

        public void disp()
        {
            Console.WriteLine("Name Of Employee : {0}\nSalary : {1}\nNetSalary : {2}", name, salary, Net_Salary);
        }

    }
}
