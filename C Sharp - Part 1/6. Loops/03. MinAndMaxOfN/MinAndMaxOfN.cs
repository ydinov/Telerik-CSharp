//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxOfN
{
    static void Main()
    {
        int n = 0;
        int number;
        int min = 0;
        int max = 0;
        
        Console.Write("Please, enter how many numbers you want to compare: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (n <= 1)
        {
            Console.Write("Please enter at 2: ");
            n = int.Parse(Console.ReadLine());
        }
        
        Console.Write("Please, enter N1: ");
        number = int.Parse(Console.ReadLine());
        min = number;
            
        for (int i = 2; i <= n; i++)
        {
            Console.Write("Please, enter N{0}: ", i);
            number = int.Parse(Console.ReadLine());
            min = Math.Min(number, min);
            max = Math.Max(number, max);
        }
        if (min == max)
        {
            Console.WriteLine("Your numbers are equal.");
        }
        else
        {
            Console.WriteLine("Min Number: {0}", min);
            Console.WriteLine("Max Number: {0}", max);
        }
    }
}