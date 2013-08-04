/*Write a program that, depending on the user's choice inputs int, double or string variable. 
  If the variable is integer or double, increases it with 1. 
  If the variable is string, appends "*" at its end. 
  The program must show the value of that variable as a console output. Use switch statement.*/

using System;

class UserChoice
{
    static void Main()
    {
        Console.WriteLine("Please, choose the type of your input:");
        Console.WriteLine("For String type 1.");
        Console.WriteLine("For Integer type 2.");
        Console.WriteLine("For Double type 3.");
        Console.Write("Please, enter your choice: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please, enter your string: ");
                string text = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Output: {0}" + "*", text);
                break;
            case 2:
                Console.Write("Please, enter your number: ");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber = intNumber + 1;
                Console.WriteLine();
                Console.WriteLine("Output: {0}", intNumber);
                break;
            case 3:
                Console.Write("Please, enter your number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber = doubleNumber + 1;
                Console.WriteLine();
                Console.WriteLine("Output: {0}", doubleNumber);
                break;
            default:
                Console.WriteLine("This is not a valid choice. Now the program will end.");
                break;
        }
    }
}
