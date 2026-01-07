using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskkkkk
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] arr = new int[3, 3];


            Console.WriteLine("Enter values for 3x3 array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("\nArray in table format:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


        
            int[,] arr1 =

                {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

          
            for (int i = 0; i < 4; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 4; j++)
                {
                    rowSum += arr[i, j];
                }
                Console.WriteLine($"Sum of row {i} = {rowSum}");
            }

            Console.WriteLine();


            for (int j = 0; j < 4; j++)
            {
                int colSum = 0;
                for (int i = 0; i < 4; i++)
                {
                    colSum += arr[i, j];
                }
                Console.WriteLine($"Sum of column {j} = {colSum}");
            }



            int[,] arr2 = new int[5, 5];
            Random rand = new Random();

           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(1, 51);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

           
            for (int i = 0; i < 5; i++)
            {
                int max = arr[i, 0];
                for (int j = 1; j < 5; j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
                Console.WriteLine($"Largest in row {i} = {max}");
            }

            Console.WriteLine();

           
            for (int j = 0; j < 5; j++)
            {
                int min = arr[0, j];
                for (int i = 1; i < 5; i++)
                {
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
                Console.WriteLine($"Smallest in column {j} = {min}");
            }



        }












    }
}
