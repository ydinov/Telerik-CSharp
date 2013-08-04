/* * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
 * N = 10  N! = 3628800  2
 * N = 20  N! = 2432902008176640000  4
 * Does your program work for N = 50 000?
 * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why! */

using System;
using System.Numerics;

class CountFactorialEndZeros
{
    static void Main()
    {
        int number = 0;
        int zeros = 0;
        int reminder = 0;
        int n;
        BigInteger factorial = 1;

        do
        {
            Console.Write("Please, enter your number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            Console.WriteLine();
        }
        while (number <= 0);

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        if (n % 5 == 0)
        {
            zeros = n / 5;
            reminder = n / 5;
            while (reminder >= 5)
            {
                reminder = reminder / 5;
                zeros = zeros + reminder;
            }
        }
        /*The "if" part could be scipped if we write only:
         * zeros = n / 5;
         * check = n / 5;
         * The "while" loop will be the one, currently in "else". */
        
        else
        {
            for (; n % 5 != 0; n--)
            {
                zeros = n / 5;
                reminder = n / 5;
            }
            while (reminder >= 5)
            {
                reminder = reminder / 5;
                zeros = zeros + reminder;
            }
        }
        Console.WriteLine(factorial);
        Console.WriteLine(zeros);
    }
}