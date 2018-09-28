using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DisplayWinningBin
    {
        public void DisplayResult(SpinWheel spinWheel,Board[] rouletteBoard)
        {
            if (spinWheel.winningBin == 37)
            {
                Console.WriteLine($"The ball landed on 00 Green!");

            }
            else
            {
                Console.WriteLine($"The ball landed on {rouletteBoard[spinWheel.winningBin].number} " +
                    $"{rouletteBoard[spinWheel.winningBin].color}!");
            }
        }
    }
}
