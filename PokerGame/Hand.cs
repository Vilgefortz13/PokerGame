using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Hand
    {
        public List<string> CardsInHand { get; private set; } = new();

        public void AddCardToHand(Deck deck)
        {
            if (deck.DeckOfCards.Any(card => !string.IsNullOrEmpty(card)))
            {
                string newCard = deck.DeckOfCards.First(card => !string.IsNullOrEmpty(card));

                CardsInHand.Add(newCard);
                deck.DeckOfCards.Remove(newCard);
            }
        }

        public void ReplaceCardInHand(Deck deck, int cardPosition)
        {
            string temp = CardsInHand[cardPosition];
            CardsInHand[cardPosition] = Deck.GetCardFromTheDeck(deck.DeckOfCards);
            deck.ReturnTheCard(temp);
        }

        public void PrintCardInHand()
        {
            Console.Write("|");
            for (int i = 1; i <= CardsInHand.Count; i++)
            {
                Console.Write($" {i,-13} |");
            }
            Console.WriteLine();
            Console.Write("|");
            for (int i = 0; i < CardsInHand.Count; i++)
            {
                Console.Write($" {CardsInHand[i],-14}|");
            }
            Console.WriteLine();
        }
    }
}
