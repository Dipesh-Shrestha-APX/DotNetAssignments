using System;

// Interfaces as given
interface IAddition
{
    double Add(double a, double b);
}

interface ISubtraction
{
    double Subtract(double a, double b);
}

interface IMultiplication
{
    double Multiply(double a, double b);
}

interface IDivision
{
    double Divide(double a, double b);
}

// Class implementing multiple interfaces
class MathOperation : IAddition, ISubtraction, IMultiplication, IDivision
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return a / b;
    }
}

class Inheritance
{
    static void Main()
    {
        MathOperation math = new MathOperation();

        Console.WriteLine("Add: " + math.Add(10, 5));          // 15
        Console.WriteLine("Subtract: " + math.Subtract(10, 5)); // 5
        Console.WriteLine("Multiply: " + math.Multiply(10, 5)); // 50
        Console.WriteLine("Divide: " + math.Divide(10, 5));     // 2
    }
}
