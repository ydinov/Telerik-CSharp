//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintOneToN
{
    static void Main()
    {
        Console.WriteLine("This program prints numbers in range 1-N.");        
        Console.Write("Please, enter N: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)                                          //Integer number can be positive or negative. Here we check entered number and based on the result we use appropriate formula.
        {
            for (int number = 1; number <= n; number++)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            for (int number = 1; number >= n; number--)
            {
                Console.WriteLine(number);
            }
        }
    }
}