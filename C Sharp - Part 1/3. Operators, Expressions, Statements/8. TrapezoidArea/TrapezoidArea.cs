using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Please enter side \"a\": ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter side \"b\": ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter side \"height\": ");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Trapezoid's area is: {0}", ((a+b)*height)/2);
    }
}