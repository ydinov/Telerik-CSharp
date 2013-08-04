//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class DivideByFive
{
    static void Main()
    {
        short counter = 0; //Counter, how many number times p is available.

        Console.Write("Please, enter your first number: ");
        uint numberOne = uint.Parse(Console.ReadLine());

        Console.Write("Please, enter your second number: ");
        uint numberTwo = uint.Parse(Console.ReadLine());

        for (uint temp = numberOne; temp <= numberTwo; temp++) //Value, used for calculations
        {
            if (temp % 5 == 0)
            {
                counter++;
                temp += 4;
            }
        }
        Console.WriteLine("There are {0} numbers \"p\" between {1} and {2}.", counter, numberOne, numberTwo);
    }
}