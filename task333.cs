using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {





        static void Main()
        {

            string inputFile = "Employees.txt";


            string outputFile = "result.txt";


            string[] lines = File.ReadAllLines(inputFile);


            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string line in lines)
                {

                    string[] parts = line.Split('\\');

                    string name = parts[0];
                    string salary = parts[1];
                    string department = parts[2];


                    string result = $"{name} works in {department} and earns {salary}";

                    Console.WriteLine(result);


                    writer.WriteLine(result);
                }
            }

            Console.WriteLine("\nData written successfully to result.txt");
        }
    }
}




    
