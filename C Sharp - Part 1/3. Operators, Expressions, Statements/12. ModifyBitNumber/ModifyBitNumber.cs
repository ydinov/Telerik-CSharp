using System;

class ModifyBitNumber
{
    static void Main()
    {
        int result = 0;

        Console.Write("Please, enter your number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter bit position: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Please, enter bit value [0/1]: ");
        byte v = byte.Parse(Console.ReadLine());

        //It depends on bit value how we will exchange targeted bit.
        if (v == 0)
        {
            int mask = ~(1 << p);
            result = n & mask;
        }
        else
        {
            int mask = 1 << p;
            result = n | mask;
        }
        Console.WriteLine("After bit {0} in number {1} is exchanged with {2}, number {1} is {3}.", p, n, v, result);
    }
}