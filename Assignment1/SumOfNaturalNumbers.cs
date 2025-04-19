using System;

public class SumOfNaturalNumbers
{
    public static void Run()
    {
        Console.Write("Enter value of n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = n * (n + 1) / 2;
        Console.WriteLine($"Sum of first {n} natural numbers is: {sum}");
    }
}
