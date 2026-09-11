namespace Toolkit;

//A Uno designer would want Suit to be { get; set; } so a wild card can change color.
// Fixed for good: number
// Can change: suit
// What breaks if reversed: a card's rank changing mid-game would make scores unpredictable

public record Card
{
    public int Number { get; init; } = 3;
    public String Suit { get; init; } = "clubs";
    
};



