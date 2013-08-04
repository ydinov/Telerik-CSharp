using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {

        //I read many ideas in Telerik Academy forum, so I tried something very similar to the ones presented.

        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00a9';
        string space = " ";
        Console.WriteLine("{0}{0}{1}", space, copyRight);
        Console.WriteLine("{0}{1}{1}{1}", space, copyRight);
        Console.WriteLine("{1}{1}{1}{1}{1}", space, copyRight);
    }
}