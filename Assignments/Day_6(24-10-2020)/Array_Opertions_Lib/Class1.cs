//Q3. Accept data in an array and print sum  also store square of each element in new array.
//Q4. Accept data in an array pass it to static method let this method store cube of each element , modify original array
//Q5. Accept data in an array and print average.

using System;

namespace Array_Opertions_Lib
{
    public class Arrayoperations
    {
        int[] arr;
        int size;

        public Arrayoperations(int size)
        {
            this.size = size;
            arr = new int[size];
            Console.WriteLine("Enter The Numbers Of Array");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
        
}

