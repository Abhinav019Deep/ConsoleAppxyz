

using System;

public class gapThree
{
    public static void Main(string[] args)
    {
        for (int i = 100; i >= 5; i--)
        {
            Console.WriteLine(i);
            i = i - 2;
        }
    }
}