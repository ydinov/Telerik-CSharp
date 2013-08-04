using System;


class VariablesAndCasting
{
    static void Main()
    {
        string greeting = "Hello";
        string location = "World";
        object Concatenate = greeting + " " + location;

        Console.WriteLine("\"{0}\" is the value of object variable.", Concatenate);

        string Casted = (string) Concatenate;

        Console.WriteLine("\"{0}\" <- This is object variable as a string.",Casted);
    }
}