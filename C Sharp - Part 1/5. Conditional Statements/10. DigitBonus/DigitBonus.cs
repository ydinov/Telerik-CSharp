/* Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
 * If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
 * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
 * Use a switch statement and at the end print the calculated new value in the console. */

using System;

class DigitBonus
{
    static void Main()
    {
        byte digit = 0;
        string input = null;
        bool check = true;

        while ((!check) || (digit == 0) || (digit > 9))
        {
            Console.Write("Please, enter a digit between 1 and 9: ");
            input = Console.ReadLine();
            check = byte.TryParse(input, out digit);

        
            if (check == true)
            {
                switch (digit)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("New result is: {0}", digit * 10);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("New result is: {0}", digit * 100);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("New result is: {0}", digit * 1000);
                        break;
                    default:
                        Console.WriteLine("Error! You entered a number. You need to enter a digit between 1 and 9.");
                        Console.WriteLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error! You entered text. You need to enter a digit between 1 and 9.");
                Console.WriteLine();
            }
        }

    }
}