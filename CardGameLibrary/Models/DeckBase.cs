using CardGameLibrary.Enums;

namespace CardGameLibrary.Models;

public abstract class DeckBase
{
    private readonly List<PlayingCard> _fullDeck = new();
    private List<PlayingCard> _drawPile = new();
    protected List<PlayingCard> _discardPile = new();

    protected List<PlayingCard> DiscardPile 
    {
        get { return _discardPile;}
        set { _discardPile = value; }
    }

    protected void CreateDeck()
    {
        foreach (var suit in Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>())
        {
            foreach (var value in Enum.GetValues(typeof(CardValue)).Cast<CardValue>())
            {
                _fullDeck.Add(new PlayingCard { Suit = suit, Value = value });
            }
        }
    }

    public virtual void ShuffleDeck()
    {
        var rnd = new Random();
        _drawPile = _fullDeck.OrderBy(x => rnd.Next()).ToList();
    }

    public abstract List<PlayingCard> DealCards();

    protected virtual PlayingCard DrawOneCard()
    {
        var card = _drawPile.Take(1).First();
        _drawPile.Remove(card);
        return card;
    }
}
