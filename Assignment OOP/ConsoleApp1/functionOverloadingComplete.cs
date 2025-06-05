using System;

class MathOperations
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method to add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Method to multiply two integers
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method to multiply two doubles
    public double Multiply(double a, double b)
    {
        return a * b;
    }
}

class FunctionOveroad
{
    static void Main()
    {
        MathOperations math = new MathOperations();

        Console.WriteLine("Add int: " + math.Add(5, 3));        // 8
        Console.WriteLine("Add double: " + math.Add(5.5, 3.2)); // 8.7

        Console.WriteLine("Multiply int: " + math.Multiply(5, 3));      // 15
        Console.WriteLine("Multiply double: " + math.Multiply(5.5, 3.2)); // 17.6
    }
}
