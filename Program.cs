using System;

class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.WriteLine("Card Game");

        // TEST: instantiate a deck and display it
        Deck myDeck = new Deck();
        myDeck.Display();
        Console.WriteLine();
    }
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
        Console.Write($"|{rank}{suit}|");
    }
    
}

class Deck
{
    // attribute
    private Card[] cards;

    // constructor
    public Deck()
    {
        // instantiate a bunch of cards
        char[] suits = new char[] {'D','S','C','H'};
        cards = new Card[52];

        int count = 0;

        foreach (char suit in suits)
        {
            for (int rank = 1; rank <= 13; rank++)
            {
                cards[count] = new Card(suit, rank);
                count++;
            }
        }
    }

    public void Display()
    {
        foreach(Card card in cards)
        {
            card.Display();
        }   
    }
}