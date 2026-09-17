using System.Xml;

namespace Toolkit;

//A Uno designer would want Suit to be { get; set; } so a wild card can change color.
// Fixed for good: number
// Can change: suit
// What breaks if reversed: a card's rank changing mid-game would make scores unpredictable



public record Suit(string Name = "Clubs", string Color = "Black")
{
    public static Suit Clubs => new Suit("Clubs", "Black");
    public static Suit Hearts => new Suit("Hearts", "Red");
    public static Suit Diamonds => new Suit("Diamonds", "Red");
    public static Suit Spades => new Suit("Spades", "Black");
}

public record Card
{
    public int Value { get; init; }
    public Suit Suit { get; init; }
    public bool IsFaceUp { get; init; } 
    
    private Card(int value, Suit suit, bool isFaceUp)
    {
        Value = value;
        Suit = suit;
        IsFaceUp = isFaceUp;
    }

    //hw 9/17
    public static Card Of(int value, Suit suit, bool isFaceUp = true)
    {
        if (value < 1 || value > 14)
            throw new ArgumentOutOfRangeException(
                nameof(value), value, $"A card has a number between 1 and 14.");

        string[] validSuits = ["Clubs", "Hearts", "Diamonds", "Spades"];
        if (!validSuits.Contains(suit.Name))
            throw new ArgumentOutOfRangeException(
                nameof(suit), suit, $"A suit can only be diamonds, hearts, clubs, or spades.");

        return new Card(value, suit, isFaceUp);

    }
    
    public static List<Card> FullDeck()
    {
        Suit[] suits = [Suit.Clubs, Suit.Hearts, Suit.Diamonds, Suit.Spades];
        List<Card> deck = new();

        for (int i = 1; i <= 13; i++)
        {
            foreach (Suit suit in suits)
            {
                deck.Add(Card.Of(i, suit));
            }
        }

        Console.WriteLine();
        return deck;
    }
    
    

}



