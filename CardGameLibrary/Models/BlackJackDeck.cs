namespace CardGameLibrary.Models;

public class BlackJackDeck : DeckBase
{
    public BlackJackDeck()
    {
        CreateDeck();
        ShuffleDeck();
    }

    public override List<PlayingCard> DealCards()
    {
        List<PlayingCard> cards = new();
        for (int i = 0; i < 2; i++)
        {
            cards.Add(DrawOneCard());
        }
        return cards;
    }

    public PlayingCard RequestCard()
        =>DrawOneCard();
    
}
