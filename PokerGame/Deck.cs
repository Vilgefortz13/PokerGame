using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Deck
    {
        private const int CountOfSuits = 4;
        private const int CountOfValues = 13;
        public List<string> DeckOfCards { get; private set; } = new();

        public void InitializeDeck()
        {
            for (int i = 0; i < CountOfSuits; i++)
            {
                for (int j = 0; j < CountOfValues; j++)
                {
                    DeckOfCards.Add($"{(Value)j}-{(Suit)i}");
                }
            }
        }

        public static string GetCardFromTheDeck(List<string> deck)
        {
            Random random = new();
            int removeElement = random.Next(0, deck.Count);
            string card = deck[removeElement];
            deck.RemoveAt(removeElement);
            deck.Insert(removeElement, null);

            return card;
        }

        public static void ShuffleTheDeck(List<string> deck)
        {
            Random random = new();
            for (int i = deck.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                (deck[i], deck[j]) = (deck[j], deck[i]);
            }
        }

        public void ReturnTheCard(string card)
        {
            if (DeckOfCards.Contains(card))
            {
                Console.WriteLine("This card exists in the deck!");
                return;
            }

            DeckOfCards.Add(card);
        }
    }
}
