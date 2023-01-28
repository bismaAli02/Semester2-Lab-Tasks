using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame.GL
{
    class Deck
    {
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (i == 0)
                    {
                        Cards.Add(new Card(j + 1, 1));
                    }
                    if (i == 1)
                    {
                        Cards.Add(new Card(j + 1, 2));
                    }
                    if (i == 2)
                    {
                        Cards.Add(new Card(j + 1, 3));
                    }
                    if (i == 3)
                    {
                        Cards.Add(new Card(j + 1, 4));
                    }
                }
            }
        }
        public static int DealNumber = 0;
        List<Card> Cards = new List<Card>();
        public void shuffle()
        {
            Random RanObj = new Random();
        Label:;
            int RanNum = RanObj.Next() % 52;
            if (!(RanNum > 3))
                goto Label;
            Card[] TempCards = new Card[RanNum];
            // stroring temporary the shuffling cards
            for (int i = 0; i < RanNum; i++)
            {
                TempCards[i] = Cards[i];
            }
            // shuffling cards insteatd of temp cards
            int Count = 0;
            for (int i = RanNum; i < 52; i++)
            {
                Cards[Count] = Cards[i];
                Count++;
            }
            // stroring tempcards in cards deck
            for (int i = 0; i < 52 - Count; i++)
            {
                Cards[Count] = TempCards[i];
            }
        }
        public int cardsLeft()
        {
            return (Cards.Count - DealNumber);
        }
        public Card dealCard()
        {
            DealNumber++;
            return Cards[(DealNumber - 1)];
        }
    }
}
