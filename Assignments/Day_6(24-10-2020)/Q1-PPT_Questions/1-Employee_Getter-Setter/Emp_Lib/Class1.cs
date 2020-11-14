using System;

namespace Emp_Lib
{
    public class Employee
    {
        static int getid;       //static since id should be readonly 
        //int id;
        string _name;
        double _sal;
        double _net_sal;
        public static double tds = 0.1;
        const int max_emp = 3;      //to restrict creation of employeee if number reaches 3
        const int max_sal = 50000;     //to keep a tab on salary to keep below 50000 so using cosnt

        public Employee(string name, int sal)       //employee details & object creation
        {
            /*if (sal > max_sal || sal > 0)        //if getid is less than max employeee object ie 3 it will stop taking the input 
            {
                this.Name = name;
                this.salary = sal;
            }
            else
            {
                Console.WriteLine("\n------MAX Employee record Reached Can't create more objects.------\n");
            }
            {*/
            if (getid < max_emp)        //if getid is less than max employeee object ie 3 it will stop taking the input
            {
                this.Name = name;
                this.salary = sal;
            }
            else
            {
                Console.WriteLine("\n------MAX Employee record Reached Can't create more objects.------\n");
            }
        }
                

        public int ID           //generate ID by incrementing as object gets created
        {
            get
            {
                return ++getid;
            }
        }

            //getter setter for emp name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

            //getter setter for emp salary  
        public double salary
        {
            get { return _sal; }
            set 
            {
                if (value  > max_sal || value <= 0)       //checking if salary is valid or not else throw an exception
                {
                    throw new Exception("\nPlease Enter Valid Salary Credentials.Salary Can't Be Zero OR More Than 50000,Employee Object Cant Be Created.");
                }
                _sal = value;
            }
        }
           
            //method to calculate the net sal by deducting the tds & return the tax amount & set the netsalary  after tax deduction.
        public double tds_calc()
        {
            double tax = salary * tds;
            _net_sal = salary - tax;
            return tax;
        }

        //Net salary of employee
        public double Net
        {
            get { return _net_sal; }
        }
    }
}
