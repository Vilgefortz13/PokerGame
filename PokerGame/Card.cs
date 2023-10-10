using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Card
    {
        public Suit SuitOfCard { get; private set; }
        public Value ValueOfCard { get; private set; }

        public Card()
        {
            SuitOfCard = Suit.Hearts;
            ValueOfCard = Value.Four;
        }

        public override string ToString()
        {
            return $"{ValueOfCard}-{SuitOfCard}";
        }
    }
}
