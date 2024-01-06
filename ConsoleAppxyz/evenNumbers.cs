using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz
{
    internal class evenNumbers
    {
        static void Main()
        {
            for (int i = 1; i<=100; i++) 
            {
                if(i % 2 == 0)
                 Console.WriteLine(i+" ");
            }
            //Console.WriteLine(" ");

            // by using while loop

            int j = 101;
            while (j <= 200){
                if(j%2==0)
                    Console.Write(j+" ");

                j++;
            }

            //Console.WriteLine(" ");

            // by using do while loop

            int k = 201;
            do
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k+" ");
                }
                k++;

            }while (k<=300);
        }

    }
}
