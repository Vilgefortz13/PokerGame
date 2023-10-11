namespace PokerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Deck deck = new();
            deck.InitializeDeck();



            Deck.ShuffleTheDeck(deck.DeckOfCards);

            Hand hand = new();
            for (int i = 0; i < 5; i++)
            {
                //foreach(var c in deck.DeckOfCards)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.WriteLine("_________________________________________________________");
                hand.AddCardToHand(deck);
            }
            hand.PrintCardInHand();

            Console.WriteLine("Do you wand to replace any cards? (spell it with spaces)");

            Console.Write("Number of cards: ");
            string input = Console.ReadLine();
            if (input != "")
            {
                string[] positions = input.Split(' ');
                int[] cardsToReplace = Array.ConvertAll(positions, int.Parse);

                for (int i = 0; i < cardsToReplace.Length; i++)
                {
                    cardsToReplace[i]--;
                    hand.ReplaceCardInHand(deck, cardsToReplace[i]);
                }
            }

            hand.PrintCardInHand();
            Console.WriteLine(deck.DeckOfCards.Count);
        }
    }
}