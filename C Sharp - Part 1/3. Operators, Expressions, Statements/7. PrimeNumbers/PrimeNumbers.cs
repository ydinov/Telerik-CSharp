using System;

class PrimeNumbers
{
    static void Main()
    {
        //We need to check only whether n divides to prime numbers to 10 as the last number 100 is square of 10.

        Console.Write("Please enter your number: ");
        int n = int.Parse(Console.ReadLine());

        bool number = ((n % 2 > 0) && (n % 3 > 0) && (n % 5 > 0) && (n % 7 > 0)) || !((n / 2 > 1) || (n / 3 > 1) || (n / 5 > 1) || (n / 7 > 1));
        Console.WriteLine("Your number is prime: {0}", number);
 
    }
}