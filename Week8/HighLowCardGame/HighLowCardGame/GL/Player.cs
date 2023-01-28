using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame.GL
{
    class Player
    {
        public Player(Card currentCard)
        {
            this.currentCard = currentCard;
        }
        private Card currentCard;
        private int Score;
        public Card getCurrentCard()
        {
            return currentCard;
        }
        public void setCurrentCard(Card Sourc)
        {
            currentCard = Sourc;
        }
        public void IncrementInScoreByOne()
        {
            Score++;
        }
        public int getScore()
        {
            return Score;
        }
    }
}
