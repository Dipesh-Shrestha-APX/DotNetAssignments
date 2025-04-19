using System;

public class FactorialCalculator
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 2; i <= num; i++)
            factorial *= i;

        Console.WriteLine($"Factorial of {num} is {factorial}");
    }
}
