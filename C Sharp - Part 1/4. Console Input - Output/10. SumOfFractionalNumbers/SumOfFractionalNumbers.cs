//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumOfFractionalNumbers
{
    static void Main()
    {
        float n = 2;
        float sum = 1;

        //Numbers, bigger or equal to 0.0005 are rounded to 0.001.
        //So to have maximum precision, we should include rounded numbers too, not to cut the number at 0.001 position.
        for (n = 2; (1 / n) >= 0.0005; n++)
        {
            if (n % 2 == 0)
            {
                sum = sum + (1 / n);
            }
            else
            {
                sum = sum - (1 / n);
            }
        }
        Console.WriteLine("The sum of 1+1/2-1/3+... with precision of 0.001 is: {0:F3}", sum);
    }
}