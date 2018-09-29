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
            SpecificNumberBet specificNumberBet = new SpecificNumberBet();
            EvenOrOdd evenOrOddBet = new EvenOrOdd();
            ColorBet colorBet = new ColorBet();
            LowHigh lowHighBet = new LowHigh();
            Dozen dozenBet = new Dozen();
            Columns columnBet = new Columns();
            Rows rowBet = new Rows();
            DoubleRows doubleRowBet = new DoubleRows();
            Split splitBet = new Split();
            Corner cornerBet = new Corner();
            SpinWheel spinWheel = new SpinWheel(rng);
            DetermineWin determineWin = new DetermineWin();
            DisplayPossibleWinningBets displayPossibleWinningBets = new DisplayPossibleWinningBets();
            DisplayWinningBin displayWinningBin = new DisplayWinningBin();
            int categoryChoice;

            //for (int i = 0; i < 100; i++)
            //{
            //    doubleRowBet.row1= 1;
            //    doubleRowBet.row2 = 2;
            //    spinWheel.Spin();
            //    displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
            //    determineWin.IsDoubleRowsWin(spinWheel, doubleRowBet);
            //    Console.ReadLine();
            //    Console.Clear();
            //}
            do
            {
                DisplayBoard(rouletteBoard);
                getBet.DisplayPossibleBets();
                categoryChoice = getBet.GetBetCategoryChoice();
                switch (categoryChoice)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            specificNumberBet.numberBettingOn = getBet.GetNumberBet();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsSpecificNumberWin(spinWheel, specificNumberBet, rouletteBoard);
                            break;
                        }
                    case 2:
                        {
                            colorBet.colorBettingOn = getBet.GetColorBet();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsRedBlackWin(spinWheel,colorBet, rouletteBoard);
                            break;
                        }
                    case 3:
                        {
                            evenOrOddBet.evenOrOdd = getBet.EvensOdds();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsEvenOddsWin(spinWheel, evenOrOddBet, rouletteBoard);
                            break;
                        }
                    case 4:
                        {
                            lowHighBet.high = getBet.LowHighBet();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsLowHighWin(spinWheel, lowHighBet, rouletteBoard);
                            break;
                        }
                    case 5:
                        {
                            dozenBet.dozen = getBet.DozensBet();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsDozensWin(spinWheel, rouletteBoard, dozenBet);
                            break;
                        }
                    case 6:
                        {
                            columnBet.column = getBet.ColumnBet();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsColumnsWin(spinWheel, columnBet);
                            break;
                        }
                    case 7:
                        {
                            rowBet.row = getBet.RowBet();
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsRowWin(spinWheel, rowBet);
                            break;
                        }
                    case 8:
                        {
                            getBet.DoubleRowBet(doubleRowBet);
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsDoubleRowsWin(spinWheel, doubleRowBet);
                            break;
                        }
                    case 9:
                        {
                            getBet.SplitBet(splitBet);
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsSplitWin(spinWheel, splitBet, rouletteBoard);
                            break;
                        }
                    case 10:
                        {
                            getBet.CornerBet(cornerBet);
                            spinWheel.Spin();
                            displayWinningBin.DisplayResult(spinWheel, rouletteBoard);
                            determineWin.IsCornerWin(spinWheel, cornerBet, rouletteBoard);
                            break;
                        }
                }
                Console.WriteLine("Hit enter to continue");
                Console.ReadLine();
                Console.Clear();
            } while (categoryChoice != 0);



        }

        public static Board[,] CreateBoard()
        {
            Board[,] rouletteBoard = new Board[3,12];
            int number;
            for(int i=0;i<3;i++)
            {
                for (int j=0;j<12;j++)
                {
                    if(i==0)
                    {
                        number = j*3+3;
                        if (number == 1 || number == 3 || number == 5 || number == 7 || number == 9 || number == 12 
                            || number == 14 || number == 16 || number == 18 || number == 19 || number == 21 
                            || number == 23 || number == 25 || number == 27 || number == 30 || number == 32 
                            || number == 34 || number == 36)
                        {
                                rouletteBoard[i, j] = new Board(number, "R");
                        }
                        else
                        {
                            rouletteBoard[i, j] = new Board(number, "B");
                        }
                    }
                    else if (i == 1)
                    {
                        if(j==0)
                        {
                            number = 2;
                        }
                        else
                        {
                            number = j * 3 + 2;

                        }
                        if (number == 1 || number == 3 || number == 5 || number == 7 || number == 9 || number == 12
                            || number == 14 || number == 16 || number == 18 || number == 19 || number == 21
                            || number == 23 || number == 25 || number == 27 || number == 30 || number == 32
                            || number == 34 || number == 36)
                        {
                            rouletteBoard[i, j] = new Board(number, "R");
                        }
                        else
                        {
                            rouletteBoard[i, j] = new Board(number, "B");
                        }
                    }
                    else
                    {
                        if(j==0)
                        {
                            number = 1;
                        }
                        else
                        {
                            number = j * 3 + 1;
                        }
                        if (number == 1 || number == 3 || number == 5 || number == 7 || number == 9 || number == 12
                            || number == 14 || number == 16 || number == 18 || number == 19 || number == 21
                            || number == 23 || number == 25 || number == 27 || number == 30 || number == 32
                            || number == 34 || number == 36)
                        {
                            rouletteBoard[i, j] = new Board(number, "R");
                        }
                        else
                        {
                            rouletteBoard[i, j] = new Board(number, "B");
                        }
                    }
                   
                }
            }
            return rouletteBoard;
        }
        public static void DisplayBoard(Board[,] rouletteBoard)
        {
            string output;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    output = String.Format("{0,-1}{1,-4} ", rouletteBoard[i, j].number, rouletteBoard[i, j].color);
                    Console.Write(output);
                }
                Console.WriteLine();
            }
        }
        //public static Object[] Bets()
        //{
        //    Object[] bets = new object[10];
        //    SpecificNumberBet specificNumberBet = new SpecificNumberBet();
        //    EvenOrOdd evenOrOddBet = new EvenOrOdd();
        //    ColorBet colorBet= new ColorBet();
        //    LowHigh lowHighBet = new LowHigh();
        //    Dozen dozenBet = new Dozen();
        //    Columns columnBet = new Columns();
        //    Rows rowBet=new Rows();
        //    DoubleRows doubleRowBet = new DoubleRows();
        //    Split splitBet = new Split();
        //    CornerBet cornerBet = new CornerBet();
        //    bets[0]=specificNumberBet;
        //    bets[1]=evenOrOddBet;
        //    bets[2]=colorBet;
        //    bets[3]=lowHighBet;
        //    bets[4]=dozenBet;
        //    bets[5]=columnBet;
        //    bets[6] = rowBet;
        //    bets[7]=doubleRowBet;
        //    bets[8]=splitBet;
        //    bets[9]=cornerBet;
        //    //bets.Add(specificNumberBet);
        //    //bets.Add(evenOrOddBet);
        //    //bets.Add(colorBet);
        //    //bets.Add(lowHighBet);
        //    //bets.Add(dozenBet);
        //    //bets.Add(columnBet);
        //    //bets.Add(rowBet);
        //    //bets.Add(doubleRowBet);
        //    //bets.Add(splitBet);
        //    //bets.Add(cornerBet);
        //    return bets;
            
        //}

    }
}
