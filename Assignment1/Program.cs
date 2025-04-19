using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose a program to run:");
            Console.WriteLine("1. Print Hello and Your Name");
            Console.WriteLine("2. Swap Two Numbers");
            Console.WriteLine("3. Find Largest of Three Numbers");
            Console.WriteLine("4. Check Even or Odd");
            Console.WriteLine("5. Sum of n Natural Numbers");
            Console.WriteLine("6. Leap Year Checker");
            Console.WriteLine("7. Sum of Integer Array");
            Console.WriteLine("8. Factorial Calculator");
            Console.WriteLine("9. Prime Number Checker");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": PrintHello.Run(); break;
                case "2": SwapNumbers.Run(); break;
                case "3": LargestOfThree.Run(); break;
                case "4": EvenOrOdd.Run(); break;
                case "5": SumOfNaturalNumbers.Run(); break;
                case "6": LeapYearChecker.Run(); break;
                case "7": ArraySum.Run(); break;
                case "8": FactorialCalculator.Run(); break;
                case "9": PrimeChecker.Run(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }
}
