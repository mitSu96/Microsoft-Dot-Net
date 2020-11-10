using System;

namespace EmpSal_lib
{
    public class Employee
    {
        int id;
        static int getid;
        string name;
        double salary, net_salary;
        const int maxemp = 3;
        const int maxsal = 800000;
        static double TDS = 0.1;

            //decrement the id 
        public static void decid()
        {
            getid--;
        }

            //Employee class
        public Employee(string name, double sal)
        {
            id = ++getid;                               //id increments after obj creation
            if (getid > maxemp)
            {
                throw new Max_Emp("Maximum Number Of Employees Reached No More Records Can be inserted");    //exception if the count reaches 3 
            }
            this.name = name;
            if (sal > maxsal)
             {
                throw new Max_Sal("Salary For employee Should Not Exceed 80000 ,Please enter Valid Input.");
             }
            this.salary = sal;
            cal_netsal();
        }

            //net salary calculation
        void cal_netsal()
        {
            this.net_salary = salary - (salary * TDS);
        }

            //Display method
        public void disp()
        {
            //Console.WriteLine("---------Details Of Salary Of Employee-------");
            Console.WriteLine("\nName Of Employee : {0}\nSalary : {1}\nNetSalary : {2}" , name ,salary,net_salary);
        }
    }

    //maximum employee reached exception
    public class Max_Emp : Exception
    {
        public Max_Emp(String meesage)
        {

        }
    }

    //maximum salary of employee cant take as input
    public class Max_Sal : Exception
    {
        public Max_Sal(String Message)
        {

        }
    }

}
