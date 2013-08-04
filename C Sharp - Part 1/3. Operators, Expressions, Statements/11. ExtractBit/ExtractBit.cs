using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Please, enter your number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number as binary is: {0}", Convert.ToString(i, 2).PadLeft(32, '0'));

        Console.Write("Please, enter bit position: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int bit = (i & mask) >> b;

        Console.WriteLine("Bit {0} in number {1} is: {2}", b, i, bit);
    }
}