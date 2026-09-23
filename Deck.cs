namespace Toolkit;

public record Deck(List<Card> Cards)
{
    public void Shuffle()
    {
        var rng = new Random();
        Cards.Shuffle();
    }

    public List<Card> Deal()
    {
        return Cards;
    }

    public (Deck, Deck) Split()
    {
        var firstDeck = Cards.GetRange(0, Cards.Count / 2);
        var secondDeck = Cards.GetRange(Cards.Count / 2, Cards.Count - Cards.Count / 2);
        return (new Deck(firstDeck), new Deck(secondDeck));
    }

    public Deck Cut()
    {
        
    }
}