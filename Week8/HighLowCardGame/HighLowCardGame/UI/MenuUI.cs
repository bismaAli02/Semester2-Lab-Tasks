using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame.UI
{
    class MenuUI
    {
        public static char MainMenu()
        {
            Console.WriteLine("Press 1. To Play Game");
            char option;
            char.TryParse(Console.ReadLine(), out option);
            return option;
        }
    }
}
