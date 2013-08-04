using System;

class InvertedSignes
{
    static void Main()
    {
        int counter = 0;
        for (int i = 2; ; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(i * (-1));
            }
            counter++;
            if (counter == 10)
            {
                break;
            }
        }

    }
}
