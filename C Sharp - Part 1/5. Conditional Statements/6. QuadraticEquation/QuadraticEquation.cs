//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.


using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        double xOne = 0;
        double xTwo = 0;
        
        Console.WriteLine("This solves quadratic equasion ax^2 + bx + c = 0.");

        Console.Write("Please, enter \"a\": ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please, enter \"b\": ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please, enter \"c\": ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);
        if (discriminant < 0)
        {
            Console.WriteLine("Your equasion doesn't have a solution.");
            return;
        }
        else if (discriminant == 0)
        {
            xOne = xTwo = -b / 2 * a;
            Console.WriteLine("Roots of this equation are:\r\nX1 = X2 = {0:0.##}", xOne);
        }
        else
        {
            xOne = (-b + Math.Sqrt(discriminant)) / 2 * a;
            xTwo = (b + Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("Roots of this equation are:\r\nX1 = {0:0.##}\r\nX2 = {1:0.##}", xOne, xTwo);
        }
    }
}