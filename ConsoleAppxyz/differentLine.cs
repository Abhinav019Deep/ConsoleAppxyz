

using System;

public class differentLine
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter your first number : ");
        string i = Console.ReadLine();
        int.Parse(i);
        Console.WriteLine("Enter your second number : ");
        int j = int.Parse(Console.ReadLine());

        Console.WriteLine("The first number is : " + i);
        Console.Write("The second number is : " + j);

    }
}