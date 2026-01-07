using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] jagged = new int[3][];

            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[4];

            
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine($"Enter values for row {i + 1}:");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"Element [{i}][{j}] = ");
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + "\t");
                }
                Console.WriteLine();
            }


            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged1 = new int[rows][];

            
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter length of row {i + 1}: ");
                int length = int.Parse(Console.ReadLine());
                jagged[i] = new int[length];
            }

            
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine($"Enter elements for row {i + 1}:");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[][] jagged2 = new int[5][];
            Random rand = new Random();

            
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new int[i + 1]; 

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = rand.Next(1, 101);
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                int sum = 0;
                Console.Write($"Row {i + 1}: ");

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                    sum += jagged[i][j];
                }

                Console.WriteLine($"=> Sum = {sum}");
            }

        }
    }
}
