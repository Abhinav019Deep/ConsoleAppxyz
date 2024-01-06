using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz
{
    internal class airthmeticOperations2
    {

        static void Main()
        {

            Console.WriteLine("enter your choice : ");

            int choice = int.Parse(Console.ReadLine());

            //Console.WriteLine(choice);

            int x = 5; int y = 10;

            if (choice == 0)
            {
                sum(x, y);
            }
            else if (choice == 1)
            {
                divide(x, y);
            }
            else if (choice == 2)
            {
                minus(x, y);
            }
            else if (choice == 3)
            {
                multiplication(x, y);
            }
            else
            {
                Console.WriteLine("enter choice between 0 to 3");
            }


        }
        static void sum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(" Sum of numbers are : " + z);
        }

        static void minus(int x, int y)
        {
            int z = x - y;
            Console.WriteLine("minus of numbers are : " + z);
        }

        static void multiplication(int x, int y)
        {
            int z = x * y;
            Console.WriteLine("Multiplication of numbers are : " + z);
        }

        static void divide(int x, int y)
        {
            int z = x / y;
            Console.WriteLine("Divion of numbers are : " + z);
        }
    }
}
