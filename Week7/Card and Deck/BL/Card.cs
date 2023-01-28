using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_and_Deck.BL
{
    class Card
    {
        public Card(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
        private int suit;
        private int value;
        public int GetSuit()
        {
            return suit;
        }
        public int GetValue()
        {
            return value;
        }
        public void SetSuit(int suit)
        {
            this.suit = suit;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public void SetCard(int suit, int value)
        {
            SetSuit(suit);
            SetValue(value);
        }

    }
}
