using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Please enter a whole number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Your number is even.");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }
    }
}