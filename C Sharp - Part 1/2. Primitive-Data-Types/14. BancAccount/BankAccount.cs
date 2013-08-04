using System;
using System.Globalization;

class BankAccount
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        string iban;
        double moneyBalance = 0;
        string bankName;
        string bicCode;
        ulong creditCardOne;
        ulong creditCardTwo;
        ulong creditCardThree;
        string check; //Variable, used to check entered data.
        byte counter = 0; //Counter, used for check loop.

        Console.Write("Please, enter Firts name: ");
        firstName = Console.ReadLine();

        Console.Write("Please, enter Middle name: ");
        middleName= Console.ReadLine();

        Console.Write("Please, enter Last name: ");
        lastName = Console.ReadLine();

        do
        {
            Console.Write("Please, enter IBAN: ");
            iban = Console.ReadLine();

            Console.Write("Please, re-enter IBAN: "); //Check whether IBAN is correctly typed.
            check = Console.ReadLine();

            if (iban == check)
            {
                counter = 0;
                continue;
            }
            else
            {
                Console.WriteLine("IBAN don't match!");
                counter++;
            }
        }
        while (counter > 0);

        do
        {
            try
            {
                Console.Write("Account balance: ");
                moneyBalance = double.Parse(Console.ReadLine());
                counter = 0;
            }
            catch (Exception) // In system settings, decimal point could be "." or ",".
            {
                Console.WriteLine("Please, try with \".\" or \",\"");
                counter++;
            }
        }
        while (counter > 0);

        Console.Write("Name of Bank Institution: ");
        bankName = Console.ReadLine();

        Console.Write("Bank BIC: ");
        bicCode = Console.ReadLine();

        do
        {
            Console.Write("Please, enter first credit card number: ");
            creditCardOne = ulong.Parse(Console.ReadLine());

            Console.Write("Please, re-enter first credit card number: "); //Check whether card number is correctly typed.
            check = Console.ReadLine();
        
            if (check.Equals(creditCardOne.ToString()))
            {
                counter = 0;
                continue;
            }
            else
            {
                Console.WriteLine("Credit card number do not match!");
                counter++;
            }
        }
        while (counter > 0);

        do
        {
            Console.Write("Please, enter second credit card number: ");
            creditCardTwo = ulong.Parse(Console.ReadLine());

            Console.Write("Please, re-enter second credit card number: ");  //Check whether card number is correctly typed.
            check = Console.ReadLine();

            if (check.Equals(creditCardTwo.ToString()))
            {
                counter = 0;
                continue;
            }
            else
            {
                Console.WriteLine("Credit card number do not match!");
                counter++;
            }
        }
        while (counter > 0);

        do
        {
            Console.Write("Please, enter third credit card number: ");
            creditCardThree = ulong.Parse(Console.ReadLine());

            Console.Write("Please, re-enter third credit card number: "); //Check whether card number is correctly typed.
            check = Console.ReadLine();

            if (check.Equals(creditCardThree.ToString()))
            {
                counter = 0;
                continue;
            }
            else
            {
                Console.WriteLine("Credit card number do not match!");
                counter++;
            }
        }
        while (counter > 0);

        Console.WriteLine("\nCustomer {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("IBAN: {0}; Ballance: {1}.",iban, moneyBalance.ToString("C", CultureInfo.CreateSpecificCulture("bg-BG")));
        Console.WriteLine("Bank: {0}; BIC: {1}", bankName, bicCode);
        Console.WriteLine("Credit Cards:\nCredit card number: {0}\nCredit card number: {1}\nCredit card number: {2}",creditCardOne.ToString(
            "#### #### #### ####"), creditCardTwo.ToString(
            "#### #### #### ####"), creditCardThree.ToString(
            "#### #### #### ####"));
    }
}