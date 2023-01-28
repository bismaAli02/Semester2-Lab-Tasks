using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighLowCardGame.GL;
namespace HighLowCardGame.UI
{
    class PlayerUI
    {
        public static void ShowCurrentCard(Card Source)
        {
            Console.WriteLine("Your Current Card Is " + Source.toString());
        }
        public static int GetPrediction()
        {
            Console.WriteLine("Press 1. If next card is High...");
            Console.WriteLine("Press 2. If next card is Low ...");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void Clrscr()
        {
            Console.Clear();
        }
        public static void DisplayScore(int score)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Your Score is + " + score.ToString());
        }
    }
}
