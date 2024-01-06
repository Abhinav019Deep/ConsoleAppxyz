using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz
{
    internal class airthmeticOperations
    {

        static void Main()
        {
            int x = 5; int y = 10;
            sum(x, y);
            divide(x, y);
            minus(x, y);
            multiplication(x, y);



            //Console.WriteLine("enter your both numbers");
        }
        static void sum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }

        static void minus(int x, int y)
        {
            int z = x - y;
            Console.WriteLine(z);
        }

        static void multiplication(int x, int y)
        {
            int z = x * y;
            Console.WriteLine(z);
        }

        static void divide(int x, int y)
        {
            int z = x / y;
            Console.WriteLine(z);
        }
    }
}
