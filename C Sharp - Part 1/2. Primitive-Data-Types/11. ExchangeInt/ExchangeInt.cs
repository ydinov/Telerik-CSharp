using System;

class ExchangeInt
{
    static void Main()
    {
        int five = 5;
        int ten = 10;

     Console.WriteLine("{0} <-> {1}", five, ten);

        five = five + ten;
        ten = (five - ten);
        five = (five - ten);

        Console.WriteLine("{0} <-> {1}", five, ten);
    }
}