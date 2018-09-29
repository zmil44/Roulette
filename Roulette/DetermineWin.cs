using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DetermineWin
    {
        public void IsSpecificNumberWin(SpinWheel spinWheel, SpecificNumberBet specificNumberBet,Board[,] rouletteBoard)
        {
            if(rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number==specificNumberBet.numberBettingOn)
            {
                Console.WriteLine("Your bet won!");
            }
            else
            {
                Console.WriteLine("Your bet did not win");
            }
        }

        public void IsEvenOddsWin(SpinWheel spinWheel, EvenOrOdd evenOrOddBet,Board[,] rouletteBoard)
        {
            if (evenOrOddBet.evenOrOdd ==true && (rouletteBoard[spinWheel.winningRow,spinWheel.winningColumn].number %2==0))
            {
                Console.WriteLine("Your Even Bet won");
            }
            else if (evenOrOddBet.evenOrOdd == false && (rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number % 2 != 0))
            {
                Console.WriteLine("Your odd bet won");
            }
            else
            {
                Console.WriteLine("Your bet did not win");
            }
        }

        public void IsRedBlackWin(SpinWheel spinWheel, ColorBet colorBet,Board[,] rouletteBoard)
        {
            if(colorBet.colorBettingOn.Equals('R') && rouletteBoard[spinWheel.winningRow ,spinWheel.winningColumn].color.Equals('R'))
            {
                Console.WriteLine("Your color bet on red won");
            }
            else if (colorBet.colorBettingOn.Equals('B') && rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].color.Equals('B'))
            {
                Console.WriteLine("Your color bet on black won");
            }
            else
            {
                Console.WriteLine("Your color bet did not win");
            }

        }

        public void IsLowHighWin(SpinWheel spinWheel, LowHigh lowHighBet, Board[,] rouletteBoard)
        {
            if(rouletteBoard[spinWheel.winningRow,spinWheel.winningColumn].number >18 
                && rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number <= 36
                && lowHighBet.high==true)
            {
                Console.WriteLine("Your high bet won");
            }
            else if (rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number >=1
                && rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number <= 18 
                && lowHighBet.high == false)
            {
                Console.WriteLine("Your low bet won");
            }
            else
            {
                Console.WriteLine("Your low high bet did not win");
            }
        }

        public void IsDozensWin(SpinWheel spinWheel,Board[,] rouletteBoard, Dozen dozenBet)
        {
            if(rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number >= 1
                && rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number <= 12 && dozenBet.dozen==1)
            {
                Console.WriteLine("Your dozen bet won");
            }
            else if (rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number >= 13
                 && rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number <= 24 && dozenBet.dozen == 2)
            {
                Console.WriteLine("Your dozen bet won");
            }
            else if (rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number >= 25
                && rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number <= 36 && dozenBet.dozen == 3)
            {
                Console.WriteLine("Your dozen bet won");
            }
            else
            {
                Console.WriteLine("Your dozen bet didnt win");
            }
            
        }
        public void IsColumnsWin(SpinWheel spinWheel, Columns columnBet)
        {
            if(spinWheel.winningColumn+1 == columnBet.column)
            {
                Console.WriteLine("Your column bet won");
            }
            else
            {
                Console.WriteLine("Your column bet didnt win");
            }

        }

        public void IsRowWin(SpinWheel spinWheel,Rows rowBet)
        {
            if (spinWheel.winningRow + 1 == rowBet.row)
            {
                Console.WriteLine("Your row bet won");
            }
            else
            {
                Console.WriteLine("Your row bet didnt win");
            }
        }

        public void IsDoubleRowsWin(SpinWheel spinWheel,DoubleRows doubleRowBet)
        {
            if (spinWheel.winningRow+1 == doubleRowBet.row1 || spinWheel.winningRow+1 == doubleRowBet.row2)
            {
                Console.WriteLine("Your double row bet won");
            }
            else
            {
                Console.WriteLine("Your double row bet didnt win");
            }
        }
        public void IsSplitWin(SpinWheel spinWheel,Split splitBet,Board[,] rouletteBoard)
        {
            if(rouletteBoard[spinWheel.winningRow,spinWheel.winningColumn].number==splitBet.number1 
                || rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number ==splitBet.number2)
            {
                Console.WriteLine("Your split bet won");
            }
            else
            {
                Console.WriteLine("Your split bet didnt win");
            }

        }
        public void IsCornerWin(SpinWheel spinWheel, Corner cornerBet, Board[,] rouletteBoard)
        {
            if (rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number == cornerBet.number1
                || rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number == cornerBet.number2
                || rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number == cornerBet.number3
                || rouletteBoard[spinWheel.winningRow, spinWheel.winningColumn].number == cornerBet.number4)
            {
                Console.WriteLine("Your Corner bet won");
            }
            else
            {
                Console.WriteLine("Your corner bet didnt win");
            }
        }
    }
}
