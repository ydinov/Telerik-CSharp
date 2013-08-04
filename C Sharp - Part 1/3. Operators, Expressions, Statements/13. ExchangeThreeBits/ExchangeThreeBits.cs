using System;

class ExchangeThreeBits
{
    static void Main()
    {
        uint middleResult = 0;                                              //Temporary number, used for calculations.
        uint endNumber = 0;                                                 //Result number after exchange.
        
        Console.Write("Please, enter your number: ");
        uint startNumber = uint.Parse(Console.ReadLine());                  //Enter & assign the initial number by user input.
        Console.WriteLine("Your number as binary is: {0}\n", Convert.ToString(startNumber, 2).PadLeft(32, '0')); //Show number in binary format.
        uint middleNumber = startNumber;                                    //Assing initial number to temporary, that will be used for calculations.

        for (byte bit = 3; bit <= 5; bit++)
        {
            int mask = 1 << bit;
            uint bitValueOne = (uint)(middleNumber & mask) >> bit;

            mask = mask << 21;                                              //We have already moved mask with 3/4/5 bits. So, to go to the 24/25/26th bit, we need to move it with 21 more.
            uint bitValueTwo = (uint)(middleNumber & mask) >> (bit + 21);

            if (bitValueOne == bitValueTwo)                                 //If source and targeted bits are the same, we can skip one iteration.
            {
                continue;
            }
            else
            {
                if (bitValueTwo == 0)
                {
                    mask = ~(1 << bit);
                    middleResult = (uint)(middleNumber & mask);
                }
                else
                {
                    mask = 1 << bit;
                    middleResult = (uint)(middleNumber | mask);
                }
                if (bitValueOne == 0)
                {
                    mask = ~(1 << bit + 21);
                    endNumber = (uint)(middleResult & mask);
                    middleNumber = endNumber;
                }
                else
                {
                    mask = 1 << (bit + 21);
                    endNumber = (uint)(middleResult | mask);
                    middleNumber = endNumber;
                }
            }
        }
        Console.WriteLine("The number you entered is {0}. After calculations number is {1}.", startNumber, endNumber);
    }
}