using System;

class PronounceNumber
{
    static void Main()
    {
        //Dummy position at index 10. It is necessary, because we are missing number 10 in this massive and not to use another if function.
        string[] singles = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "", "eleven", "twelve", "thirteen" };
        string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string hundreds = "hundred";
        int number;
        int i; //Used for last and / or single digit.
        int d; //Used for decimals digits.
        int h; //Used for hundreds digits.
        string result;
        bool check;

        Console.Write("Please, enter a number [0-999]: ");
        check = int.TryParse(Console.ReadLine(), out number);


        while ((number < 0) || (number >= 1000) || (!check))
        {
            Console.WriteLine("You didn't enter correct number.");
            Console.WriteLine();
            Console.Write("Please, enter a number [0-999]: ");
            check = int.TryParse(Console.ReadLine(), out number);
        }

        if (number < 10)
        {
            i = number;
            result = singles[i].Substring(0, 1).ToUpper() + singles[i].Substring(1);
            Console.WriteLine("Number in English is: \"{0}\".", result);
        }
        else if ((number < 20) && (number != 10))
        {
            i = number % 10 - 1;
            result = teens[i].Substring(0, 1).ToUpper() + teens[i].Substring(1);
            Console.WriteLine("Number in English is: \"{0}\".", result);
        }
        else if (number < 100)
        {
            if (number % 10 == 0)
            {
                d = number / 10 - 1;
                result = tens[d].Substring(0, 1).ToUpper() + tens[d].Substring(1);
                Console.WriteLine("Number in English is: \"{0}\".", result);
            }
            else
            {
                i = number % 10;
                d = number / 10 - 1;
                result = tens[d].Substring(0, 1).ToUpper() + tens[d].Substring(1) + " " + singles[i];
                Console.WriteLine("Number in English is: \"{0}\".", result);
            }
        }
        else
        {
            if (number % 100 == 0)
            {
                h = number / 100;
                result = singles[h].Substring(0, 1).ToUpper() + singles[h].Substring(1) + " " + hundreds;
                Console.WriteLine("Number in English is: \"{0}\".", result);
            }
            else if (number % 10 == 0)
            {
                h = number / 100;
                d = (number % 100) / 10 - 1;
                result = singles[h].Substring(0, 1).ToUpper() + singles[h].Substring(1) + " " + hundreds + " and " + tens[d];
                Console.WriteLine("Number in English is: \"{0}\".", result);
            }
            else
            {
                if (number % 100 < 10)
                {
                    h = number / 100;
                    i = number % 10;
                    result = singles[h].Substring(0, 1).ToUpper() + singles[h].Substring(1) + " " + hundreds + " and " + singles[i];
                    Console.WriteLine("Number in English is: \"{0}\".", result);
                }

                else if (number % 100 < 20)
                {
                    h = number / 100;
                    d = (number % 100) / 10 - 1;
                    result = singles[h].Substring(0, 1).ToUpper() + singles[h].Substring(1) + " " + hundreds + " and " + teens[d];
                    Console.WriteLine("Number in English is: \"{0}\".", result);
                }
                else
                {
                    h = number / 100;
                    d = (number % 100) / 10 - 1;
                    i = number % 10;
                    result = singles[h].Substring(0, 1).ToUpper() + singles[h].Substring(1) + " " + hundreds + " and " + tens[d] + " " + singles[i];
                    Console.WriteLine("Number in English is: \"{0}\".", result);
                }

            }
        }
    }
}

