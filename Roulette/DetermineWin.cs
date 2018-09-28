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
            if(rouletteBoard[spinWheel.winningBin].number==specificNumberBet.numberBettingOn)
            {
                Console.WriteLine("Your bet won!");
            }
            else
            {
                Console.WriteLine("Your bet did not win");
            }
        }
        //TODO add rouletteBoard here and use that to get actual number
        //TODO cant have 0 or 00 as even or odd numbers
        public void IsEvenOddsWin(SpinWheel spinWheel, EvenOrOdd evenOrOddBet)
        {
            if (evenOrOddBet.evenOrOdd ==true && (spinWheel.winningBin%2==0))
            {
                Console.WriteLine("Your Even Bet won");
            }
            else if (evenOrOddBet.evenOrOdd == false && (spinWheel.winningBin % 2 != 0))
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

        public void IsLowHighWin(SpinWheel spinWheel, LowHigh lowHighBet, Board[] rouletteBoard)
        {
            if(rouletteBoard[spinWheel.winningBin].number >18 && rouletteBoard[spinWheel.winningBin].number <= 36 && lowHighBet.high==true)
            {
                Console.WriteLine("Your high bet won");
            }
            else if (rouletteBoard[spinWheel.winningBin].number >=1&& rouletteBoard[spinWheel.winningBin].number <= 18 && lowHighBet.high == false)
            {
                Console.WriteLine("Your low bet won");
            }
            else
            {
                Console.WriteLine("Your low high bet did not win");
            }
        }

        public void IsDozensWin(SpinWheel spinWheel)
        {

        }
        public void IsColumnsWin(SpinWheel spinWheel)
        {

        }

        public void IsRowWin(SpinWheel spinWheel)
        {

        }

        public void IsDoubleRowsWin(SpinWheel spinWheel)
        {

        }
        public void IsSplitWin(SpinWheel spinWheel)
        {

        }
        public void IsCornerWin(SpinWheel spinWheel)
        {

        }
    }
}
