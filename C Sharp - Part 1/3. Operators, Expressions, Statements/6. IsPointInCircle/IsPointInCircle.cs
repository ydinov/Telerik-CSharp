using System;

class IsPointInCircle
{
    static void Main()
    {
        //In this example, coordinates of the circle are (O,5). Therefore, we won't calculate the difference between entered coordinates and circle coordinates.
        int r = 5; //r = radius

        Console.Write("Please, enter X coordinate: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Please, enter Y coordinate: ");
        int y = int.Parse(Console.ReadLine());

        bool check = x * x + y * y < r * r;
        Console.WriteLine("The point with coordinates ({0},{1}) is in the circle: {2}", x, y, check);
    }
}