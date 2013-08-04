//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfN
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");                  //First number in the row.
        decimal firstN = decimal.Parse(Console.ReadLine());

        Console.Write("Please, enter another number: ");            //Number variable, used as next number.
        decimal n = decimal.Parse(Console.ReadLine());
        decimal sum = firstN + n;

        Console.WriteLine("Sum is: {0}", sum);

        for (byte counter = 0; ; counter++)                         //Counter, used for the loop.
        {
            Console.Write("Do you want to continue? [Y/N]");        //Check whether user wants to continue or not.
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            if (key.KeyChar.Equals('y'))                            //If user wants to coninue, we continue to sum the numbers.
            {
                Console.Write("Please, enter next number: ");
                n = decimal.Parse(Console.ReadLine());
                sum = sum + n;

                Console.WriteLine("Sum is: {0}", sum);
                counter = 0;
            }
            else if (key.KeyChar.Equals('n'))                       //If user doesn't want to continue, we terminate the program.
            {
                Console.WriteLine("Thank you!");
                return;
            }
            else
            {
                Console.WriteLine("Please, answer with \"y\" or \"n\".");   //If user doesn't enter Y or N, we force him to do so.
                counter++;
            }
        }
    }
}