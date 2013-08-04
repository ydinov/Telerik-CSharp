using System;

class RectangleArea
{
    static void Main()
    {
        decimal width;
        decimal hight;

        Console.Write("Please, enter width as a whole number: ");
        width = decimal.Parse(Console.ReadLine());

        Console.Write("Please, enter hight as a whole number: ");
        hight = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle area is: {0}", width * hight);
    }
}