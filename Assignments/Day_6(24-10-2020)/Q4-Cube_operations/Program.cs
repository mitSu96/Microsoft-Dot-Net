//Q4. Accept data in an array pass it to static method let this method store cube of each element , modify original array

using System;
//using 

namespace Q4_Cube_operations
{
    class Program
    {
            //cube operation
        static void cube(int [] a)
        {
            int size = a.Length;
            for(int i = 0; i < size ; i++)
            {
                a[i] = a[i] * a[i] * a[i];
            }
        }
           
            //printing operation
        static void print(int [] a)
        {
            int size = a.Length;
            Console.Write("[ ");
            for(int i = 0 ; i < size ; i++)
            {
                Console.Write("{0} " ,a[i]);
            }
           Console.WriteLine("]");
        }

            //Main App Invocation
       
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("-------------Cube Of Array elements & Printing---------------\n");
            Console.WriteLine("\nEnter the size of array to be operated : \n");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];                   //creating a new array of size n
            Console.WriteLine("\nEnter data : ");         //input for array data
            
            //for loop for saving the data inside the array
            for (int i = 0; i < n; i++) 
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe Original Array : \n");
            print(a);                                   //prints the original array
            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("\nAfter cubing operation on the array ,The New Cubed Array is :\n");
            cube(a);                                    //cubes the original arrays elements
            print(a);                                   //prints the cubed element array or the modified array
            Console.ReadLine();
        }
    }
}
