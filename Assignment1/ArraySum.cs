using System;

public class ArraySum
{
    public static void Run()
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine($"Sum of array elements: {sum}");
    }
}
