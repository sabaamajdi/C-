using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    continue;
                }

                if (num == 0)
                {
                    break;
                }

                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Even numbers: " + evenCount);
            Console.WriteLine("Odd numbers: " + oddCount);




            int grade;

            while (true)
            {
                Console.Write("Enter student grade (0-100): ");
                grade = int.Parse(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    break;
                }

                Console.WriteLine("Invalid grade, try again.");
            }

            if (grade >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");



            }





            }
        }

    } 
  
