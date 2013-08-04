//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorialOfNByKOverKMinusN
{
    static void Main()
    {
        int k = 0;
        int n = 0;

        while (1 >= n || n >= k)
        {
            Console.WriteLine("Please, enter \"K\" and \"N\" such as [1 < N < K].");
            Console.Write("Please, enter K: ");
            k = int.Parse(Console.ReadLine());

            Console.Write("Please, enter N: ");
            n = int.Parse(Console.ReadLine());
        }

        BigInteger factorialK = 1;

        for (int i = k - n + 1; i <= k; i++) //Because of the division, firts k-n members of the K! will be negated.
        {
            factorialK *= i;
        }

        BigInteger factorialN = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialK *= i;
        }

        Console.WriteLine("Result: {0}", factorialN * factorialK);
    }
}