//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This solves quadratic equasion ax^2 + bx + c = 0.");
        
        Console.Write("Please, enter \"a\": ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please, enter \"b\": ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please, enter \"c\": ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);
        if (discriminant <= 0)
        {
            Console.WriteLine("Your equasion doesn't have a solution.");
            return;
        }

        double xOne = -b + Math.Sqrt(discriminant);
        double xTwo = b + Math.Sqrt(discriminant);

        Console.WriteLine("Roots of this equation are:\r\nX1 = {0:0.##}\r\nX2 = {1:0.##}", xOne, xTwo);
    }
}