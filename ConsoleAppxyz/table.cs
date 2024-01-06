using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz
{
    internal class table
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 3);
            }
            //Console.WriteLine(" ");

            // by using while loop

            int j = 1;
            while (j <= 10)
            {
                Console.Write(j * 3 + " ");
                j++;
            }

            Console.WriteLine(" ");

            // by using do while loop

            int k = 1;
            do
            {
                Console.WriteLine(k*3);
                k++;
            } while (k <= 10);
        }

    }
}
