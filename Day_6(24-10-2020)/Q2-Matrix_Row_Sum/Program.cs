//Q2. Accept data in 3*3matrix and print row wise sum

using System;

namespace Q2_Matrix_Row_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col, row_sum = 0;
            int[,] matrix = new int[3, 3];
            int[] sum = new int[3];

            Console.WriteLine("Enter Data Of The 3*3 Matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n3*3 Martix : ");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                    row_sum = row_sum + matrix[i, j];
                    sum[i] = sum[i] + matrix[i, j];
                }
                Console.WriteLine("\t\t\trow sum: " + row_sum);
                row_sum = 0;

            }
            Console.WriteLine("\nSum of rows is--");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("  " + sum[i]);
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.ReadLine();
        }
    }
}
