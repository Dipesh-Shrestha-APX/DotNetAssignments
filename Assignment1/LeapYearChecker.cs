﻿using System;

public class LeapYearChecker
{
    public static void Run()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine($"{year} is a leap year.");
        else
            Console.WriteLine($"{year} is not a leap year.");
    }
}
