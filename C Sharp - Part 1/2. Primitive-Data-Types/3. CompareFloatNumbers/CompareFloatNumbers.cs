using System;

class CompareFloatNumbers
{
    static void Main()
    {
        byte check;
        float fFirstNumber;
        float fSecondNumber;
        decimal dFirstNumber;
        decimal dSecondNumber;
        bool equal; //The variable, used for comparison.
        int counter = 0; //Counter, used for the loop if error is detected.
        int count = 0;

        Console.WriteLine("This application compares numbers with up to 6 digits after decimal point.");
        Console.Write("To use \"floating point\", type 1. To use \"decimal point\", type 2: ");
        check = byte.Parse(Console.ReadLine());

        if (check == 1)
        {
            Console.WriteLine("You are comparing numbers by \"float number\".");
            do
            {
                try
                {
                    Console.Write("Please, enter Your first number:  ");
                    fFirstNumber = float.Parse(Console.ReadLine());

                    do
                    {
                        try
                        {
                            Console.Write("Please, enter Your second number: ");
                            fSecondNumber = float.Parse(Console.ReadLine());

                            equal = Equals(fFirstNumber, fSecondNumber);
                            counter = 0;
                            count = 0;

                            if (equal == false)
                                Console.WriteLine("{0} is not equal to {1}.", fFirstNumber, fSecondNumber);
                            else
                                Console.WriteLine("{0} is equal to {1}.", fFirstNumber, fSecondNumber);
                        }
                        catch
                        {
                            Console.WriteLine("Please, try with \".\" or \",\"");
                            count++;
                        }
                    }
                    while (count > 0);
                }
                catch (Exception) // In system settings, decimal point could be "." or ",".
                {
                    Console.WriteLine("Please, try with \".\" or \",\"");
                    counter++;
                }
            }
            while (counter > 0);
        }
        if (check == 2)
        {
            Console.WriteLine("You are comparing numbers by \"float number\".");
            do
            {
                try
                {
                    Console.Write("Please, enter Your first number:  ");
                    dFirstNumber = decimal.Parse(Console.ReadLine());

                    do
                    {
                        try
                        {
                            Console.Write("Please, enter Your second number: ");
                            dSecondNumber = decimal.Parse(Console.ReadLine());

                            equal = Equals(decimal.Round(dFirstNumber,6), decimal.Round(dSecondNumber,6));
                            counter = 0;
                            count = 0;

                            if (equal == false)
                                Console.WriteLine("{0} is not equal to {1}.", decimal.Round(dFirstNumber, 6), decimal.Round(dSecondNumber,6));
                            else
                                Console.WriteLine("{0} is equal to {1}.", decimal.Round(dFirstNumber, 6), decimal.Round(dSecondNumber, 6));
                        }
                        catch
                        {
                            Console.WriteLine("Please, try with \".\" or \",\"");
                            count++;
                        }
                    }
                    while (count > 0);
                }
                catch (Exception) // In system settings, decimal point could be "." or ",".
                {
                    Console.WriteLine("Please, try with \".\" or \",\"");
                    counter++;
                }
            }
            while (counter > 0);
        }
        else
        {
            Console.WriteLine("Please, choose 1 or 2.");
        }
    }
}