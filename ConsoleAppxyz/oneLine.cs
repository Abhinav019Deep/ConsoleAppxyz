

using System;

public class oneLine
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter your first number : ");
        string i = Console.ReadLine();
        int.Parse(i);
        Console.WriteLine("Enter your second number : ");
        int j = int.Parse(Console.ReadLine());

        Console.Write("The numbers are : " + i + " and " + j);

    }
}