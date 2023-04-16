using CardGameLibrary.Enums;
using CardGameLibrary.Models;

namespace CardGame;

internal static class ConsoleMessages
{
    internal static void DisplayGreetingMessage()
    {
        Console.WriteLine(value: "Welcome to the Card Game app!");
        Console.WriteLine(value: "It's not actually a game...");
        Console.WriteLine();
    }

    internal static void DisplayHand(List<PlayingCard> hand, GameType gameType)
    {
        PrintGameType(gameType);
        PrintHand(hand);
    }

    private static void PrintGameType(GameType gameType)
        => Console.WriteLine(value: $"********* {gameType} *********");
    
    private static void PrintHand(List<PlayingCard> hand)
    {
        foreach (var card in hand)
        {
            Console.WriteLine(card);
        }

        Console.WriteLine();
    }

    internal static void DisplayExitMessage()
        => Console.WriteLine(value: "Thanks for 'playing'...");
    
}
