using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

    class GetBet
    {
        public GetBet()
        {
        }
        public void DisplayPossibleBets()
        {
            Console.WriteLine("1. Specific number");
            Console.WriteLine("2. Color");
            Console.WriteLine("3. Even or Odd");
            Console.WriteLine("4. lows (1-18) or Highs (19-36");
            Console.WriteLine("5. Dozens (1-12, 13-24, 25-36");
            Console.WriteLine("6. columns (first second or third)");
            Console.WriteLine("7. Street (rows) (1,2,3) (4,5,6) etc etc");
            Console.WriteLine("8. numbers double rows");
            Console.WriteLine("9. split: edge of any two contiguos numbers");
            Console.WriteLine("10. corner intersecion of any four contiguous numbers (ie 1/2/4/5 or 23/24/26/27");

        }

        public int GetBetCategoryChoice()
        {
            int categoryChoice=0;
            while (categoryChoice <= 0|| categoryChoice>10)
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
                    Console.WriteLine("Enter the number you would like to bet on (for 0 enter 37 and for 00 enter 38): ");
                    bet = int.Parse(Console.ReadLine());
                    SpecificNumberBet numberBet = new SpecificNumberBet(bet - 1);

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

    }
    public  struct SpecificNumberBet
    {
        public int numberBettingOn { get; }
        public SpecificNumberBet(int number)
        {
            numberBettingOn = number;
        }
    }

    public struct ColorBet
    {
        public char colorBettingOn {get; }
        public ColorBet(char color)
        {
            colorBettingOn = color;
        }
    }

    public struct EvenOrOdd
    {
        public bool evenOrOdd { get; }
        public EvenOrOdd(bool evenOrOdd)
        {
            this.evenOrOdd = evenOrOdd;
        }
    }
    public struct LowHigh
    {
        bool lowHigh;
        public LowHigh(bool lowHigh)
        {
            this.lowHigh = lowHigh;
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
        public int column { get; }
        public Columns(int column)
        {
            this.column = column;
        }
    }
    public struct Rows
    {
        public int row { get; }
        public Rows(int row)
        {
            this.row = row;
        }
    }
    public struct DoubleRows
    {
        public int row1 { get; }
        public int row2 { get; }
        public DoubleRows(int row1, int row2)
        {
            this.row1 = row1;
            this.row2 = row2;
        }
    }
    public struct Split
    {
        int number1 { get; }
        int number2 { get; }
        public Split(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
    }
    public struct CornerIntersection
    {
        public int number1 { get; }
        public int number2 { get; }
        public int number3 { get; }
        public int number4 { get; }
        public CornerIntersection(int number1, int number2, int number3, int number4)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
            this.number4 = number4;
        }

    }

}
