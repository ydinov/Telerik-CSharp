//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;

class SignOfRealNumbersProduct
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The sign of the product of the three number is 0.");
        }
        else if ((firstNumber > 0 && secondNumber > 0) || (firstNumber < 0 && secondNumber < 0))
        {
            if (thirdNumber > 0)
            {
                Console.WriteLine("The sign of the product of the three number is \"+\".");
            }
            else if (thirdNumber < 0)
            {
                Console.WriteLine("The sign of the product of the three number is \"-\".");
            }
        }
        else if (firstNumber < 0 || secondNumber < 0)
        {
            if (thirdNumber > 0)
            {
                Console.WriteLine("The sign of the product of the three number is \"-\".");
            }
            else if (thirdNumber < 0)
            {
                Console.WriteLine("The sign of the product of the three number is \"+\".");
            }
        }
    }
}