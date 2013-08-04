//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class SumOfFibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please, enter how many members of Fibonacci Sequence you want to sum: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger firstMember = 0;
        BigInteger secondMember = 1;
        BigInteger sum = 1;
        BigInteger memberMinusTwo = firstMember;
        BigInteger memberMinusOne = secondMember;

        for (int i = 3; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                memberMinusOne = memberMinusTwo + memberMinusOne;
                sum = sum + memberMinusOne;

                /*The same would be if we say:
                 * currentMember = memberMinusOne + memberMinusTwo;
                 * sum = sum + curentMember;
                 * memberMinusTwo = memberMinusOne;
                 * memberMinusOne = currentMember;*/
            }
            else
            {
                memberMinusTwo = memberMinusTwo + memberMinusOne;
                sum = sum + memberMinusTwo;
            }
        }
        Console.WriteLine("Sum of the first {0} Fibonacci members is: {1}", n, sum);
    }            
}