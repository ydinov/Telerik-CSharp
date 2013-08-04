using System;

class ExchangeBitsPAndQ
{
    static void Main()
    {
        uint middleResult = 0;                                              //Temporary number, used for calculations.
        uint endNumber = 0;                                                 //Result number after exchange.

        Console.Write("Please, enter your number: ");
        uint startNumber = uint.Parse(Console.ReadLine());                  //Enter & assign the initial number by user input.
        Console.WriteLine("Your number as binary is: {0}\n", Convert.ToString(startNumber, 2).PadLeft(32, '0')); //Show number in binary format.
        uint middleNumber = startNumber;                                    //Assing initial number to temporary, that will be used for calculations.

        Console.Write("Please, enter your first group bit position: ");
        byte firstBit = byte.Parse(Console.ReadLine());                     //Enter the starting bit of first (source) group -> p

        Console.Write("Please, enter second group bit position: ");
        byte secondBit = byte.Parse(Console.ReadLine());                    //Enter the starting bit of second (target) group -> q

        Console.Write("Please, enter the number of bits in to be exchanged: ");
        byte bitCount = byte.Parse(Console.ReadLine());                     //Enter how many bits to be exchnage (group size) -> k
        byte difference = (byte)(secondBit - firstBit);                     //What is the difference (in bits) between starting bits of both groups.

        for (byte useBit = firstBit; useBit <= (firstBit + bitCount - 1); useBit++) //useBit is a variable, used for calculations, so other variables can save their initial values.
        {
            int mask = 1 << useBit;
            uint bitValueOne = (uint)(middleNumber & mask) >> useBit;

            mask = mask << difference;                                      //We have already moved mask with p bits. So, to go to the bit q, we need to move it with (q - p) more.
            uint bitValueTwo = (uint)(middleNumber & mask) >> (useBit + difference);

            if (bitValueOne == bitValueTwo)
            {
                continue;
            }
            else
            {
                if (bitValueTwo == 0)
                {
                    mask = ~(1 << useBit);
                    middleResult = (uint)(middleNumber & mask);
                }
                else
                {
                    mask = 1 << useBit;
                    middleResult = (uint)(middleNumber | mask);
                }
                if (bitValueOne == 0)
                {
                    mask = ~(1 << useBit + difference);
                    endNumber = (uint)(middleResult & mask);
                    middleNumber = endNumber;
                }
                else
                {
                    mask = 1 << (useBit + difference);
                    endNumber = (uint)(middleResult | mask);
                    middleNumber = endNumber;
                }
            }
        }
        Console.WriteLine("The number you entered is {0}. After calculations number is {1}.", startNumber, endNumber);
    }
}