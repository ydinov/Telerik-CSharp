using System;

class ASCIITable
{
    static void Main()
    {
        char i = (char)0x00;
        do
        {
            Console.Write(i+" ");
            i++;            
        } 
        while (i <= 0x7F);
        Console.WriteLine("\n"); //Just to see "Press any key to continue on a new line.
    }
}