using System;

class NullValues
{
    static void Main()
    {
        int? valueOne = null;
        double? valueTwo = null;

        Console.WriteLine("Null Integer: .{0}.", valueOne);
        Console.WriteLine("Null Double: .{0}.", valueTwo);
        
        valueOne = 2;
        
        Console.WriteLine("Null Integer with value: .{0}.", valueOne);
        
        Console.WriteLine("Null value + number:{0}.{1}.", valueTwo, valueOne);
    }
}