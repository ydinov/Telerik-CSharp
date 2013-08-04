//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("Please, enter your first number: ");
        double numberOne = double.Parse(Console.ReadLine());

        Console.Write("Please, enter your second number: ");
        double numberTwo = double.Parse(Console.ReadLine());
        
        Console.WriteLine(Math.Max(numberOne, numberTwo));
    }
}