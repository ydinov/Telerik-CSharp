//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        Console.Write("Please, enter circle radius: ");
        int r = int.Parse(Console.ReadLine());

        Console.WriteLine("Circle area is: {0:0.00}", r*r*Math.PI);
        Console.WriteLine("Circle perimeter is: {0:0.00}", 2*r*Math.PI);
    }
}