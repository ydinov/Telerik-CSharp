using System;

class ThirdBitIsOne
{
    static void Main()
    {
        Console.Write("Please, enter your number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        bool check = ((number & mask) >> 3) == 1;
        
       Console.WriteLine("Third bit is 0: {0}", !check);
       Console.WriteLine("Third bit is 1: {0}", check);
    }
}