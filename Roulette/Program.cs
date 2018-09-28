using System;
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
            SpecificNumberBet numberBet = new SpecificNumberBet();
            SpinWheel spinWheel = new SpinWheel(rng);
            DetermineWin determineWin = new DetermineWin();
            DisplayPossibleWinningBets displayPossibleWinningBets = new DisplayPossibleWinningBets();
            DisplayWinningBin displayWinningBin = new DisplayWinningBin();
            int categoryChoice;
            //test numbers
            //for (int i = 0; i < 100; i++)
            //{
            //    numberBet.NewSpecificNumberBet(1);
            //    spinWheel.Spin();
            //    displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
            //    determineWin.IsSpecificNumberWin(spinWheel, numberBet, rouletteBoard);
            //}
            do
            {
                getBet.DisplayPossibleBets();
                categoryChoice = getBet.GetBetCategoryChoice();
                numberBet.numberBettingOn=getBet.GetNumberBet();
                spinWheel.Spin();
                displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                determineWin.IsSpecificNumberWin(spinWheel, numberBet, rouletteBoard);
            } while (categoryChoice != 0);



        }

        public static Board[] CreateBoard()
        {
            Board[] rouletteBoard = new Board[38];
            for (int i = 0; i < rouletteBoard.Length; i++)
            {
                if (i == 0)
                {
                    rouletteBoard[i] = new Board(i, "Green");
                }
                else if(i==37)
                {
                    rouletteBoard[i] = new Board(i, "Green");

                }
                else if (i == 1 ||i==3|| i == 5 || i == 7 || i == 9 || i == 12 || i == 14 || i == 16
                        || i == 18 || i == 19 || i == 21 || i == 23 || i == 25 || i == 27 || i == 30
                        || i == 32 || i == 34 || i == 36)
                {
                    rouletteBoard[i] = new Board(i, "Red");
                }
                else
                {
                    rouletteBoard[i] = new Board(i, "Black");
                }
            }
            return rouletteBoard;
        }

    }
}
