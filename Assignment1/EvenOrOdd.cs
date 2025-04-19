using System;

public class EvenOrOdd
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}
