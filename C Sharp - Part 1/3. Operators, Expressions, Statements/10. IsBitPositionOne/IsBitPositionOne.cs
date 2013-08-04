using System;

class IsBitPositionOne
{
    static void Main()
    {
        Console.Write("Please, enter your number: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number as binary is: {0}", Convert.ToString(v, 2).PadLeft(32, '0'));

        Console.Write("Please, enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        bool check = ((v & mask) >> p) == 1;

        Console.WriteLine("Bit {0} in number {1} is 1: {2}", p, v, check);
    }
}