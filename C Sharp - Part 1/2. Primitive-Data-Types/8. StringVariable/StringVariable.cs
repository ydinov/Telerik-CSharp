using System;

class StringVariable
{
    static void Main()
    {
        string Quoted = @"The ""use"" of quotations causes difficulties.";
        string Unquoted = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("Quoted string: {0}\nUnquoted string: {1}", Quoted, Unquoted);
    }
}