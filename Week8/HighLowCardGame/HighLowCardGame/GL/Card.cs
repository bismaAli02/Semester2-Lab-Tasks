using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame.GL
{
    class Card
    {
        public Card(int value, int suit)
        {
            this.suit = suit;
            this.value = value;
        }

        private int suit;
        private int value;
        public String getSuitAsString()
        {
            if (suit == 1)
                return "Clubs";
            if (suit == 2)
                return "Diamonds";
            if (suit == 3)
                return "Spades";
            if (suit == 4)
                return "Hearts";
            return null;
        }
        public String getValueAsString()
        {
            if (value == 1)
                return "Ace";
            if (value == 11)
                return "Jack";
            if (value == 12)
                return "Queen";
            if (value == 13)
                return "King";
            return value.ToString();
        }
        public String toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
        public int getValue()
        {
            return value;
        }
    }
}
