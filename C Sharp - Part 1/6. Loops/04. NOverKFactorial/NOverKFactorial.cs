//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class NOverKFactorial
{
    static void Main()
    {
        int n = 0;
        int k = 0;
        
        while (1 >= k || k >= n)
        {
            Console.WriteLine("Please, enter \"N\" and \"K\" such as [1 < K < N].");
            Console.Write("Please, enter N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Please, enter K: ");
            k = int.Parse(Console.ReadLine());
        }
        
        decimal factorial = 1;

        for (int i = k + 1; i <= n; i++) 
        {
            factorial *= i;
        }
        Console.WriteLine("Result: {0}", factorial);
 	}
}