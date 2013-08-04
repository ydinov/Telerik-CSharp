// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ThreeDigitSum
{
    static void Main()
    {     
        Console.Write("Please, enter your first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Please, enter your second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Please, enter your third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a+b+c);
    }
}