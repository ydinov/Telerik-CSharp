using System;

class IsThirdBitSeven
{
    static void Main()
    {
        Console.Write("Please, enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool check = (((number / 100) % 10) == 7);
        Console.WriteLine("Third digit in you number is 7: {0}", check);
    }
}