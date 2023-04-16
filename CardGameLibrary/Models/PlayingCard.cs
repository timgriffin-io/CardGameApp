using CardGameLibrary.Enums;

namespace CardGameLibrary.Models;

public class PlayingCard
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }
    public override string ToString()
        => $"{Value} of {Suit}";
    
}
