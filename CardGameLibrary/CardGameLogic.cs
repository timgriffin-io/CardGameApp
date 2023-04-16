using CardGameLibrary.Enums;
using CardGameLibrary.Models;

namespace CardGameLibrary;

public static class CardGameLogic
{
    public static List<PlayingCard> GetHand(DeckBase deck)
        => deck.DealCards();
    
}
