using System;

class DeckOfCards
{
    static void Main()
    {
        for (int c = 0; c <= 3; c++)
        {
            string[] color = { "clubs", "diamonds", "hearts", "spades" };
            Console.WriteLine(color[c].Substring(0,1).ToUpper() + color[c].Substring(1) + ":");
            
            for (int r = 0; r <= 12; r++)
            {
                string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
                Console.WriteLine("{0} of {1}", rank[r], color[c]);
            }
            Console.WriteLine();
        }
    }
}