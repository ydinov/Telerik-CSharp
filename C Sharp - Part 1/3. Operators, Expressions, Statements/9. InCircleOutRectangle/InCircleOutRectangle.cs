using System;

class InCircleOutRectangle
{
    static void Main()
    {
        int circleX = 1;
        int circleY = 1;
        int circleR = 3;
        int rectTop = 1;
        int rectLeft = -1;
        int rectWidth = 6;
        int rectHeight = 2;

        Console.Write("Please, enter X coordinate of your point: ");
        decimal x = decimal.Parse(Console.ReadLine()); // X coordinate for the checked point.

        Console.Write("Please, enter Y coordinate of your point: ");
        decimal y = decimal.Parse(Console.ReadLine()); // Y coordinate for the checked point.

        bool check = ((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) < circleR * circleR) // Checks whether point is in the circle.
            && ((rectLeft + rectWidth < x || x < rectLeft) && (rectTop - rectHeight > y || y > rectTop)); // Check whether point is out of the rectangle.
        Console.WriteLine("The point with coordinates ({0},{1}) is in the circle K(1,1,3) and out of the rectangle R:\n{2}", x, y, check);
    }
}