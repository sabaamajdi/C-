using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            Console.WriteLine(text);
            double x = 11.1;
            Console.WriteLine(x);
            string name = "sabaa";
            Console.WriteLine(name);
            char myChar = 'o';
            Console.WriteLine(myChar);
            bool b = false;
            Console.WriteLine(b);
            int i = 8;
            Console.WriteLine(i);

            const int y = 1000;
            Console.WriteLine(y);



            string[] cars = { "Lexus", "Porsche", "Mercedes", "BMW" };

            for (int s = 0; s < cars.Length; s++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("Array Length: " + cars.Length);

            Console.WriteLine("input your first name: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("input your last name: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("input your   year of  birth: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(firstname + " " + lastname + " " + year);



            int[] arr = new int[10];

            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write("element - " + z + " : ");
                arr[z] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + " ");









            }
        }
    }
}
