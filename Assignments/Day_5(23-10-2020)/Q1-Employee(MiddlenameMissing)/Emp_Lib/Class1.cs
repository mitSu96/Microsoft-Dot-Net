using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Lib
{
    public class Employee
    {
        /*static Employee()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n****************Corporation Of Unknowns***************\n");
            Console.WriteLine("-----------------------------------------------------\n");
        }*/

        string Fname, Mname, Lname;

        public Employee(string Fname, string Mname, string Lname)               //employee method ttaking in all three characters
        {
            this.Fname = Fname;
            this.Mname = Mname;
            this.Lname = Lname;
            //Console.WriteLine("Construtor Of 3 parameters");              //here we can print this line to show that app is calling three arg const
        }

        public Employee(string Fname, string Lname)                             //employee method taking in only first & last name in employee class
        {
            this.Fname = Fname;
            this.Lname = Lname;
            //Console.WriteLine("Construtor Of 2 parameters");              //here we can print this line to show that app is calling 2 arg const
        }
        
        public void disp()
        {
            if (this.Mname == null)                                                     //if middle name is not provide then the retunrn print will display only first & last name
                Console.WriteLine(" Employee Name : {0} {1}", Fname, Lname);        
            else                                                                        //e;se the print dispaly all the three charcters enterd by the user
                Console.WriteLine("Employee Name : {0} {1} {2}", Fname, Mname, Lname);      
        }
    }
}
