using CardGame;
using CardGameLibrary;
using CardGameLibrary.Enums;
using CardGameLibrary.Models;

ConsoleMessages.DisplayGreetingMessage();

var hand = CardGameLogic.GetHand(new PokerDeck());
ConsoleMessages.DisplayHand(hand, GameType.Poker);

hand = CardGameLogic.GetHand(new BlackJackDeck());
ConsoleMessages.DisplayHand(hand, GameType.Blackjack);

ConsoleMessages.DisplayExitMessage();
