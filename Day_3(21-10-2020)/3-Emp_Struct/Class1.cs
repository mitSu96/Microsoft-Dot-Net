//Q3. Create struct emp having member name and salary, using constructor initialized member. Write display method which will display name and salary

using System;

namespace _3_Emp_Struct
{
    public struct emp
    {
        string name;
        double salary;
        public emp(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void disp_details()
        {
            Console.WriteLine("Employee Name : {0}\nEmployee Salary : {1}", name, salary);
        }
    }
}
