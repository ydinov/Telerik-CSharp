//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class SumOfFactorialOverPower
{
    static void Main()
    {
        Console.Write("Please, enter N: ");
        decimal n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter X: ");
        decimal x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        
        for (decimal i = n; i > 0 ; i--)
        {
            sum = sum * (i/x) + 1; //We can present equation as: S = 1 + 1/X*(1 + 1/X*(...(1 + N/X)))
        }
        Console.WriteLine();
        Console.WriteLine("Sum is: {0:F2}", sum);



        Console.WriteLine();

        Console.Write("Please, enter N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Please, enter X: ");
        int X = int.Parse(Console.ReadLine());

        decimal Sum = 1;
        BigInteger factorial = 1;
        BigInteger power = 1;


        for (int i = 1; i <= N; i++)
        {
            factorial *= i;
            power *= X;

            BigInteger divided = factorial / power;
            BigInteger reminderInt = factorial % power;
            if (reminderInt < 10)
            {
                reminderInt = reminderInt * 100;
            }
            else if (reminderInt < 100)
            {
                reminderInt = reminderInt * 10;
            }

            string reminderText = reminderInt.ToString();
            decimal reminder = decimal.Parse(reminderText.Substring(0, 3));
            Sum = Sum + (decimal)divided + (reminder / 1000);

            //Console.WriteLine(testOne);
            //Console.WriteLine(testTwo);
            //Console.WriteLine(testThreee);
            //Console.WriteLine(testFour);
            //Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("Sum is: {0:F2}", Sum);
        //Console.WriteLine(factorial);
        //Console.WriteLine(power);

    }
}