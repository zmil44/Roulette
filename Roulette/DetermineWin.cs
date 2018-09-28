using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DetermineWin
    {
        public void IsSpecificNumberWin(SpinWheel spinWheel, SpecificNumberBet specificNumberBet,Board[] rouletteBoard)
        {
            if(rouletteBoard[spinWheel.winningBin+1].number==specificNumberBet.numberBettingOn)
            {
                Console.WriteLine("Your bet won!");
            }
            else
            {
                Console.WriteLine("Your bet did not win");
            }
        }

        public void IsEvenOddsWin(SpinWheel spinWheel, EvenOrOdd evenOrOddBet)
        {
            if (evenOrOddBet.evenOrOdd ==true && (spinWheel.winningBin+1%2==0))
            {
                Console.WriteLine("Your Even Bet won");
            }
            else if (evenOrOddBet.evenOrOdd == false && (spinWheel.winningBin + 1 % 2 != 0))
            {
                Console.WriteLine("Your odd bet won");
            }
            else
            {
                Console.WriteLine("Your bet did not win");
            }
        }

        public void IsRedBlackWin(SpinWheel spinWheel, ColorBet colorBet,Board[] rouletteBoard)
        {
            if(colorBet.colorBettingOn.Equals('R') && rouletteBoard[spinWheel.winningBin + 1].color.Equals('R'))
            {
                Console.WriteLine("Your color bet on red won");
            }
            else if (colorBet.colorBettingOn.Equals('B') && rouletteBoard[spinWheel.winningBin + 1].color.Equals('B'))
            {
                Console.WriteLine("Your color bet on black won");
            }
            else
            {
                Console.WriteLine("Your color bet did not win");
            }

        }

        public void IsLowHighWin(SpinWheel spinWheel, LowHigh lowHighBet)
        {
            if(spinWheel.winningBin+1 >18)
            {

            }
        }

        public void IsDozensWin()
        {

        }
        public void IsColumnsWin()
        {

        }

        public void IsRowWin()
        {

        }

        public void IsDoubleRowsWin()
        {

        }
        public void IsSplitWin()
        {

        }
        public void IsCornerWin()
        {

        }
    }
}
