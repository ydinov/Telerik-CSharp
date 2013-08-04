/* * Write a program that reads a positive integer number N (N < 20) from console and 
 * outputs in the console the numbers 1 ... N numbers arranged as a spiral.
 * Example for N = 4
 *  1  2  3 4
 * 12 13 14 5
 * 11 16 15 6
 * 10  9  8 7 */

using System;

class SnakeMatrix
{
    static void Main()
    {
        
        int n = 0;

        do
        {
            Console.Write("Please, enter size [N] of the matrix, such as [N<20]: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        while (n <= 0 || n >= 20);

        int rows = n;
        int cols = n;
        int[,] matrix = new int[rows, cols];

        rows = cols = 0;
        int i = 1; // Next number in the matrix.

        do
        {
            //Move right
            for (; cols < n && matrix[rows, cols] == 0; cols++)
            {
                matrix[rows, cols] = i;
                i++;
            }

            //Change the direction of the flow and go to the next position in the matrix for writing.
            cols--;
            rows++;

            //Move down
            for (; rows < n && matrix[rows, cols] == 0; rows++)
            {
                matrix[rows, cols] = i;
                i++;
            }

            rows--;
            cols--;

            //Move left
            for (; cols >= 0 && matrix[rows, cols] == 0; cols--)
            {
                matrix[rows, cols] = i;
                i++;
            }

            cols++;
            rows--;

            //Move up
            for (; rows >= 0 && matrix[rows, cols] == 0; rows--)
            {
                matrix[rows, cols] = i;
                i++;
            }

            rows++;
            cols++;
        }
        while (i <= n * n);

        for (rows = 0; rows < n; rows++)
        {
            for (cols = 0; cols < n; cols++)
            {
                if (n <= 3)
                {
                    Console.Write("|{0, 2} ", matrix[rows, cols]);
                }
                else if (n <= 9)
                {
                    Console.Write("|{0, 3} ", matrix[rows, cols]);
                }
                else if (n <= 13)
                {
                    Console.Write("|{0, 4} ", matrix[rows, cols]);
                }
                else
                {
                    Console.WindowWidth = (n - 13) * 6 + 80; //Expanding console window, so the matrix can be visible. 80 is defaul size and we need 6 more positions for each number, higher than 13.
                    Console.Write("|{0, 4} ", matrix[rows, cols]);
                }
            }
            Console.Write("|");
            Console.WriteLine();
        }
    }
}