using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

           
            Console.WriteLine("\nList elements:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            List<string> students = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter student name {i + 1}: ");
                students.Add(Console.ReadLine());
            }

           
            students.Sort();

           
            Console.WriteLine("\nStudent names (sorted):");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

            List<int> numbers1= new List<int>();
            int input;

           
            Console.WriteLine("Enter numbers (-1 to stop):");
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input == -1)
                    break;

                numbers.Add(input);
            }

            
            Console.WriteLine("\nAll elements:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"\nAverage = {average}");

            
            int max = numbers[0];
            int min = numbers[0];

            foreach (int n in numbers)
            {
                if (n > max) max = n;
                if (n < min) min = n;
            }

            Console.WriteLine($"Largest number = {max}");
            Console.WriteLine($"Smallest number = {min}");

            
            numbers.Sort();

            Console.WriteLine("\nSorted list (ascending):");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }


        }
    }
}
