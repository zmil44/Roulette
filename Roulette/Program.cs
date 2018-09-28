﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var rouletteBoard = CreateBoard();
            Random rng = new Random();
            GetBet getBet= new GetBet();
            SpinWheel spinWheel = new SpinWheel(rng);
            DetermineWin determineWin = new DetermineWin();
            DisplayPossibleWinningBets displayPossibleWinningBets = new DisplayPossibleWinningBets();
            DisplayWinningBin displayWinningBin = new DisplayWinningBin();
            getBet.DisplayPossibleBets();
            int categoryChoice = getBet.GetBetCategoryChoice();
            SpecificNumberBet numberBet = new SpecificNumberBet(getBet.GetNumberBet());
            spinWheel.Spin();
            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
            determineWin.IsSpecificNumberWin(spinWheel, numberBet, rouletteBoard);
            
        }

        public static Board[] CreateBoard()
        {
            Board[] rouletteBoard = new Board[38];
            for (int i = 1; i <= rouletteBoard.Length; i++)
            {
                if (i == 37)
                {
                    rouletteBoard[i - 1] = new Board(0, "Green");
                }
                else if(i==38)
                {
                    rouletteBoard[i - 1] = new Board(38, "Green");

                }
                else if (i == 1 || i == 2 || i == 5 || i == 7 || i == 9 || i == 12 || i == 14 || i == 16
                        || i == 118 || i == 19 || i == 21 || i == 23 || i == 25 || i == 27 || i == 30
                        || i == 32 || i == 34 || i == 36)
                {
                    rouletteBoard[i - 1] = new Board(i, "Red");
                }
                else
                {
                    rouletteBoard[i - 1] = new Board(i, "Black");
                }
            }
            return rouletteBoard;
        }

    }
}
