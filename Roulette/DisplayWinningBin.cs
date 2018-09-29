﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DisplayWinningBin
    {
        public void DisplayResult(SpinWheel spinWheel,Board[,] rouletteBoard)
        {
                Console.WriteLine($"The ball landed on {rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number} " +
                    $"{rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].color}!");
        }
    }
}
