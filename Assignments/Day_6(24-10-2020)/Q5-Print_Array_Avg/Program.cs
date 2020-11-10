//Q5. Accept data in an array and print average.

using System;

namespace Q5_Print_Array_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            float avg = 0;
                //Invocation
            Console.WriteLine("Enter the size of array : ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
                //data entry
            Console.WriteLine("\nEnter the data of array : ");
            for (int i = 0; i < n; i++)             //for loop for entering data inside array
            {
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];            //calculating the sum of array elements
            }
            avg = sum / n;          //averaage of array elements using sum from above data entry

            Console.WriteLine();
                //Printing of array
            Console.WriteLine("Array Is : \n");
            Console.Write("[ ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("]");
                //avg of array element
            Console.WriteLine("\nAverage Of numbers Of Above {0} Array elements : {1}", n, avg);
            Console.ReadLine();
        }
    }
}
