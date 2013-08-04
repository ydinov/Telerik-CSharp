//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class SubsetEqualsZero
{
    static void Main()
    {
        string[] stringNumber = { "N1", "N2", "N3", "N4", "N5" }; //Used for defining subset in console printing phase.

        Console.Write("Please, enter your first number [N1]: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter your second number [N2]: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter your third number [N3]: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter your fourth number [N4]: ");
        int fourthNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter your fifth number [N5]: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        int[] number = {firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber}; 

        Console.WriteLine();
        Console.WriteLine("Susbsets equal to ZERO are:");
        Console.WriteLine();
        bool check = false; //Variable, used to check, wheather there is at least one subset, that equals 0.

        for (int i = 0; i <= 3; i++)
        {
            for (int j = i + 1; j <= 4; j++)
            {
                if (number[i] + number[j] == 0)
                {
                    Console.WriteLine("Subset [{0}, {1}]: {2} + {3} = 0", stringNumber[i], stringNumber[j], number[i], number[j]);
                    check = true;
                }
                for (int k = j + 1; k <= 4; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        Console.WriteLine("Subset [{0}, {1}, {2}]: {3} + {4} + {5} = 0", stringNumber[i], stringNumber[j], stringNumber[k], number[i], number[j], number[k]);
                        check = true;
                    }
                    for (int l = k + 1; l <= 4; l++)
                    {
                        if (number[i] + number[j] + number[k] + number[l] == 0)
                        {
                            Console.WriteLine("Subset [{0}, {1}, {2}, {3}]: {4} + {5} + {6} + {7} = 0", stringNumber[i], stringNumber[j], stringNumber[k], stringNumber[l], number[i], number[j], number[k], number[l]);
                            check = true;
                        }
                        else if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
                        {
                            Console.WriteLine("Subset [N1:N5]: {0} + {1} + {2} + {3} + {4} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
                            check = true;
                            return;
                        }
                    }
                }
            }
        }
        if (!check)
        {
            Console.WriteLine("There is no such subset.");
        }
    }
}