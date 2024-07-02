using System;

class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.WriteLine("Card Game");

        // TEST: instantiate a card
        Card card1 = new Card('D', 4);
        // use the new card's Display method to, er, display it
        card1.Display()
        ;    }
}

class Card
{
    
    // attribute
    private char suit;
    private int rank;

    public Card(char s, int r)
    {
        suit = s;
        rank = r;
    }

    public char GetSuit()
    {
        return suit;
    }

    public int GetRank()
    {
        return rank;
    }

    public void Display()
    {  
        Console.Write($"{rank} {suit}");
    }
    
}