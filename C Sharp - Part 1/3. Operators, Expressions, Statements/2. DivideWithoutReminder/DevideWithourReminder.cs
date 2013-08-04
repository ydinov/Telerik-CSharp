using System;

class DevideWithourReminder
{
    static void Main()
    {
        Console.Write("Please, enter a whole number: ");
        int number = int.Parse(Console.ReadLine());

        bool check = ((number % 5 == 0) && (number % 7 == 0));
        
        Console.WriteLine("{0} can be devided by 5 and 7 in the same time: {1}", number, check);
    }
}