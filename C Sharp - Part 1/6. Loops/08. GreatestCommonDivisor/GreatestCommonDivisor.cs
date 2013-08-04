//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Please, enter your first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please, enter your second number: ");
        double b = double.Parse(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("GCD = a = b = {0}", a);
        }
        else if (a > b)
        {
            double divider = b;
            double reminder = a % b;
            double gcd = b; //In case a % b == 0 and b is the GCD.

            while (reminder != 0)
            {
                gcd = reminder;
                reminder = divider % reminder;
                divider = gcd;
            }
            Console.WriteLine("GCD = {0}", gcd);
        }
        else
        {
            double divider = a;
            double reminder = b % a;
            double gcd = a; //In case b % a == 0 and a is the GCD.

            while (reminder != 0)
            {
                gcd = reminder;
                reminder = divider % reminder;
                divider = gcd;
            }
            Console.WriteLine("GCD = {0}", gcd);
        }
    }
}