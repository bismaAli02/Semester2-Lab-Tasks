using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighLowCardGame.GL;
using HighLowCardGame.UI;
namespace HighLowCardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck DeckOfCards = new Deck();
            DeckOfCards.shuffle();
            Player User = new Player(DeckOfCards.dealCard());
            char MenuOption = MenuUI.MainMenu();
            if (MenuOption == '1')
            {
                while (DeckOfCards.cardsLeft() != 0)
                {
                    PlayerUI.Clrscr();
                    PlayerUI.ShowCurrentCard(User.getCurrentCard());
                    int prediction = PlayerUI.GetPrediction();
                    if (prediction == 1)
                    {
                        Card DealtCard = DeckOfCards.dealCard();
                        if (User.getCurrentCard().getValue() > DealtCard.getValue())
                        {
                            User.IncrementInScoreByOne();
                            User.setCurrentCard(DealtCard);
                        }
                    }
                    if (prediction == 2)
                    {
                        Card DealtCard = DeckOfCards.dealCard();
                        if (User.getCurrentCard().getValue() < DealtCard.getValue())
                        {
                            User.IncrementInScoreByOne();
                            User.setCurrentCard(DealtCard);
                        }
                    }
                    PlayerUI.DisplayScore(User.getScore());
                }
                PlayerUI.Clrscr();
                PlayerUI.DisplayScore(User.getScore());
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadKey();
            }
        }
    }
}
