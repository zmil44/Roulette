using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

    class GetBet
    {
        public void DisplayPossibleBets()
        {
            Console.WriteLine("1. Specific number");
            Console.WriteLine("2. Color");
            Console.WriteLine("3. Even or Odd");
            Console.WriteLine("4. Lows (1-18) or Highs (19-36");
            Console.WriteLine("5. Dozens (1-12, 13-24, 25-36");
            Console.WriteLine("6. Columns (first second or third)");
            Console.WriteLine("7. Street (rows) (1,2,3) (4,5,6) etc etc");
            Console.WriteLine("8. Numbers double rows");
            Console.WriteLine("9. Split: edge of any two contiguos numbers");
            Console.WriteLine("10. Corner intersecion of any four contiguous numbers (ie 1/2/4/5 or 23/24/26/27");
            Console.WriteLine("0. Quit.");

        }

        public int GetBetCategoryChoice()
        {
            int categoryChoice=-1;
            while (categoryChoice < 0|| categoryChoice>10)
            {
                try
                {
                    Console.WriteLine("Enter your bet category using the corresponding number: ");
                    categoryChoice = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please try again.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Please try again.");
                }
            }
            return categoryChoice;
        }
        public int GetNumberBet()
        {
            int bet = 0;
            while (bet<= 0 || bet > 38)
            {
                try
                {
                    Console.WriteLine("Enter the number you would like to bet on (for 00 enter 37): ");
                    bet = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please try again.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Please try again.");
                }
            }
            return bet - 1;
        }
        public char GetColorBet()
        {
            char colorBet = 'N';
            while(colorBet!='R'||colorBet !='B')
            {
                Console.WriteLine("What Color would you like to bet on? enter r for red and b for black");
                colorBet = char.Parse(Console.ReadLine());
                colorBet = char.ToUpper(colorBet);
            }
            return colorBet;
        }
        public bool EvenOddBet()
        {
            bool evenOdd;
            char input = 'n';
            while(input!='E'||input!='O')
            {
                Console.WriteLine("Would you like even or odds? Enter e for evens and o for odds");
                input = char.Parse(Console.ReadLine());
                input = char.ToUpper(input);
            }
            if(input=='E')
            {
                evenOdd = true;
            }
            else
            {
                evenOdd = false;
            }
            return evenOdd;
        }

    }

    //Structs for bets
    public  struct SpecificNumberBet
    {
        public int numberBettingOn { get; set; }
    }

    public struct ColorBet
    {
        public char colorBettingOn { get; set; }

    }

    public struct EvenOrOdd
    {
        public bool evenOrOdd { get; set; }
    }
    public struct LowHigh
    {
        public bool high { get; set; }
        public void NewLowHigh(bool high)
        {
            this.high = high;
        }
    }
    public struct Dozen
    {
        public int dozen { get; }
        public Dozen(int dozen)
        {
            this.dozen = dozen;
        }
    }
    public struct Columns
    {
        public int column { get; set; }
        public void NewColumns(int column)
        {
            this.column = column;
        }
    }
    public struct Rows
    {
        public int row { get; set; }
        public void NewRows(int row)
        {
            this.row = row;
        }
    }
    public struct DoubleRows
    {
        public int row1 { get; set; }
        public int row2 { get; set; }
        public void NewDoubleRows(int row1, int row2)
        {
            this.row1 = row1;
            this.row2 = row2;
        }
    }
    public struct Split
    {
        int number1 { get; set; }
        int number2 { get; set; }
        public void NewSplit(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
    }
    public struct CornerIntersection
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
        public int number4 { get; set; }
        public void NewCornerIntersection(int number1, int number2, int number3, int number4)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
            this.number4 = number4;
        }

    }

}
