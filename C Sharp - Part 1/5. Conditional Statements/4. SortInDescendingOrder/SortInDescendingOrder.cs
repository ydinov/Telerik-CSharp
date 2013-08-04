//Sort 3 real values in descending order using nested if statements.

using System;

class SortInDescendingOrder
{
    static void Main()
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double thirdNumber = 0;
        
        //Fixed after homework check comment. Input of the numbers was after setting the variables.
        Console.Write("Please, enter first number: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        thirdNumber = double.Parse(Console.ReadLine());
        
        bool oneBiggerThanTwo = firstNumber > secondNumber;
        bool oneSmallerThanTwo = firstNumber < secondNumber;
        bool oneBiggerThanThree = firstNumber > thirdNumber;
        bool oneSmallerThanThree = firstNumber < thirdNumber;
        bool twoBiggerThanThree = secondNumber > thirdNumber;
        bool twoSmallerThanThree = secondNumber < thirdNumber;
        double biggestNumber = 0;
        double middleNumber = 0;
        double smallestNumber = 0;
        string check = null;

        

        if (oneBiggerThanTwo)
        {
            if (oneSmallerThanThree)
            {
                biggestNumber = thirdNumber;
                middleNumber = firstNumber;
                smallestNumber = secondNumber;
            }
            else if (oneBiggerThanThree)
            {
                biggestNumber = firstNumber;

                if (twoBiggerThanThree)
                {
                    middleNumber = secondNumber;
                    smallestNumber = thirdNumber;
                }
                else if (twoSmallerThanThree)
                {
                    middleNumber = thirdNumber;
                    smallestNumber = secondNumber;
                }
                else
                {
                    middleNumber = secondNumber;
                    smallestNumber = thirdNumber;
                    check = "Second and third number are equal.";
                }
            }
            else
            {
                biggestNumber = firstNumber;
                middleNumber = thirdNumber;
                smallestNumber = secondNumber;
                check = "First and third number are equal.";
            }
        }
        
        else if (oneSmallerThanTwo)
        {
            if (twoSmallerThanThree)
            {
                biggestNumber = thirdNumber;
                middleNumber = secondNumber;
                smallestNumber = firstNumber;
            }
            else if (twoBiggerThanThree)
            {
                biggestNumber = secondNumber;

                if (oneBiggerThanThree)
                {
                    middleNumber = firstNumber;
                    smallestNumber = thirdNumber;
                }
                else if (oneSmallerThanThree)
                {
                    middleNumber = thirdNumber;
                    smallestNumber = firstNumber;
                }
                else
                {
                    middleNumber = firstNumber;
                    smallestNumber = thirdNumber;
                    check = "First and third number are equal.";
                }
            }
            else
            {
                biggestNumber = secondNumber;
                middleNumber = thirdNumber;
                smallestNumber = firstNumber;
                check = "Second and third number are equal.";
            }
        }
        else
        {
            if (oneSmallerThanThree)
            {
                biggestNumber = thirdNumber;
                middleNumber = firstNumber;
                smallestNumber = secondNumber;
                check = "First and second number are equal.";
            }
            else if (oneBiggerThanThree)
            {
                biggestNumber = firstNumber;
                middleNumber = secondNumber;
                smallestNumber = thirdNumber;
                check = "First and second number are equal.";
            }
            else
            {
                Console.WriteLine("The three numbers are equal.");
                return;
            }
        }
        Console.WriteLine();
        Console.WriteLine("1. {0}", biggestNumber);
        Console.WriteLine("2. {0}", middleNumber);
        Console.WriteLine("3. {0}", smallestNumber);
        Console.WriteLine("{0}", check);
    }
}