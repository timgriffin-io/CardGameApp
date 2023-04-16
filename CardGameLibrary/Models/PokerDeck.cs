namespace CardGameLibrary.Models;

public class PokerDeck : DeckBase
{
    public PokerDeck()
    {
        CreateDeck();
        ShuffleDeck();
    }

    public override List<PlayingCard> DealCards()
    {
        List<PlayingCard> cards = new();
        for (int i = 0; i < 5; i++)
        {
            cards.Add(DrawOneCard());
        }

        return cards;
    }

    public List<PlayingCard> RequestCards(List<PlayingCard> discardCards)
    {
        List<PlayingCard> newCards = new();
        foreach (var card in discardCards)
        {
            newCards.Add(DrawOneCard());
            DiscardPile.Add(card);
        }

        return newCards;
    }
}