//Q3. Accept data in an array and print sum  also store square of each element in new array.

using System;

namespace Q3_Sum_Square_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, sum = 0, len;
            Console.WriteLine("\nEnter The Size Of Array to be created: ");
            size = int.Parse(Console.ReadLine());
            int[] a = new int[size];         //creating array of size given by user
            int[] sqr_a = new int[size];     //creating array of square of size by user
            len = a.Length;
            Console.WriteLine("\nEnter The Numbers To Be Saved Inside Array :");

            //printing the user array & sum 
            for (int i = 0; i < len; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
                sqr_a[i] = a[i] * a[i];
            }


            Console.WriteLine("\nAddition Of {0} Numbers of above array is : {1}", len, sum);

            //printing the array of squares 
            /*for (int i = 0; i < size; i++)          //using for loop
                {
                    Console.Write("{0} ", sqr_a[i]);
                }*/

            //using foreach     
            Console.WriteLine("\nSqaure's of elements of array :\n");
            foreach (int i in sqr_a)
                Console.Write(i + " ");
            Console.ReadLine();

        }
    }
}
