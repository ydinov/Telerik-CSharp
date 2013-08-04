//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        byte count = 1; //Used for count the passes in "for" cicle and for the numbering of the respective number in Fibunacci sequence.

        BigInteger firstMember = 0;
        BigInteger secondMember = 1;
        Console.WriteLine("First 100 Fibunacci numbers:");
        Console.WriteLine("{0}. {1}", count++, firstMember);
        Console.WriteLine("{0}. {1}", count++, secondMember);

        for (; count <= 100;)
        {
            firstMember = firstMember + secondMember;
            Console.WriteLine("{0}. {1}", count++, firstMember);
            secondMember = firstMember + secondMember;
            Console.WriteLine("{0}. {1}", count++, secondMember);
        }
    }
}