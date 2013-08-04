using System;

class PrintMatrix
{
    static void Main()
    {
        byte n = 0;

        while (n <= 0 || n >= 20)
        {
            Console.Write("Please, enter size of the matrix (0<N<20): ");
            n = byte.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        for (byte r = 1; r <= n; r++) //r = Rows
        {
            for (byte c = r, counter = 1; counter <= n; counter++) //c = Columns data.
            {
                Console.Write("{0, 2} ", c);
                c++;
            }
            Console.WriteLine();
        }
    }
}