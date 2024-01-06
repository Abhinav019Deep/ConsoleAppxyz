using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz
{
    internal class name
    {

        static void Main()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();


            for(int i=0; i<10; i++)
            {

                Console.WriteLine(name + i);
            }
        }
    }
}
