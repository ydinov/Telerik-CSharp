//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: C = (2n)! / ((n+1)!*n!), for n >= 0.
//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        Console.Write("Please, enter your number: ");
        uint n;
        bool check = uint.TryParse(Console.ReadLine(), out n);

        while (!check)
        {
            Console.Write("Please, enter positive integer number: ");
            check = uint.TryParse(Console.ReadLine(), out n);
        }

        BigInteger divident = 1;
        for (uint i = 1; i <= 2 * n; i++)
        {
            divident *= i;
        }

        BigInteger divisor = 1;
        BigInteger multiplierOne = 1; //(n+1)!
        BigInteger multiplierTwo = 1; //n!
        for (uint i = 1; i <= n; i++)
        {
            multiplierOne *= i;
            multiplierTwo *= i;

            if (i == n)
            {
                i++;
                multiplierOne *= i;
                divisor = multiplierOne * multiplierTwo;
            }
        }

        BigInteger result = (BigInteger)(divident / divisor);
        Console.WriteLine(result);
    }
}