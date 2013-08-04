using System;

class IsFemale
{
    static void Main()
    {
        bool isFemale = false;
        string gender;
        int counter = 0; //Counter, used in input error check loop.

        do
        {
            Console.Write("What is Your gender? ");
            gender = Console.ReadLine();

            if ((gender == "f") || (gender == "F") || (gender == "female") || (gender == "Female"))
            {
                isFemale = true;
                counter = 0;
            }
            else
            {
                if ((gender == "m") || (gender == "M") || (gender == "male") || (gender == "Male"))
                {
                    isFemale = false;
                    counter = 0;
                }
                else
                {
                    counter++;
                    Console.WriteLine("Please, use \"m\" for \"Male\" and \"f\" for \"Female\".");
                }
            }
        }
        while (counter > 0);

        Console.WriteLine("You are female: {0}",isFemale);
        Console.WriteLine("Thank You for Your participation!");
    }
}