//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestVariable
{
    static void Main()
    {
        double greatest = 0;
        
        Console.Write("Please, enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        
        Console.Write("Please, enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        
        double[] number = {firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber};

        for (int i = 0; i <= 4; i++)
        {
            if (greatest < number[i])
            {
                greatest = number[i];
            }
        }
        Console.WriteLine("Greatest number is: {0}.", greatest);
    }
}