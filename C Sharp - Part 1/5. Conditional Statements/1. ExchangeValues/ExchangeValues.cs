//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Please, enter first number \"X\": ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number \"Y\": ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("Your numbers have been exchanged:");
            Console.WriteLine("X: {0}\nY: {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Y is bigger than X.");
        }
    }
}