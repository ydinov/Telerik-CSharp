//Write a program that finds the biggest of three integers using nested if statements.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (thirdNumber > firstNumber)
            {
                Console.WriteLine("The {0} is the biggest number", thirdNumber);
            }
            else if (thirdNumber < firstNumber)
            {
                Console.WriteLine("The {0} is the biggest number", firstNumber);
            }
        }
        else if (firstNumber < secondNumber)
        {
            if (thirdNumber > secondNumber)
            {
                Console.WriteLine("The {0} is the biggest number", thirdNumber);
            }
            else if (thirdNumber < secondNumber)
            {
                Console.WriteLine("The {0} is the biggest number", secondNumber);
            }
        }
        else if (firstNumber == secondNumber)
        {
            if (thirdNumber > secondNumber)
            {
                Console.WriteLine("The {0} is the biggest number", thirdNumber);
            }
            else if (thirdNumber < secondNumber)
            {
                Console.WriteLine("The {0} is the biggest number", secondNumber);
            }
            else
            {
                Console.WriteLine("The three numbers are equal.");
            }
        }
    }
}