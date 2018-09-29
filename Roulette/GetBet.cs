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
            int categoryChoice = -1;
            while (categoryChoice < 0 || categoryChoice > 10)
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
            while (bet <= 0 || bet > 38)
            {
                try
                {
                    Console.WriteLine("Enter the number you would like to bet on (1-36): ");
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
            return bet;
        }
        public char GetColorBet()
        {
            char colorBet = 'N';
            while (colorBet != 'R' || colorBet != 'B')
            {
                Console.WriteLine("What Color would you like to bet on? enter r for red and b for black");
                colorBet = char.Parse(Console.ReadLine());
                colorBet = char.ToUpper(colorBet);
            }
            return colorBet;
        }
        public bool EvensOdds()
        {
            bool evenOdd;
            char input = 'n';
            while (input != 'E' || input != 'O')
            {
                Console.WriteLine("Would you like even or odds? Enter e for evens and o for odds");
                input = char.Parse(Console.ReadLine());
                input = char.ToUpper(input);
            }
            if (input == 'E')
            {
                evenOdd = true;
            }
            else
            {
                evenOdd = false;
            }
            return evenOdd;
        }
        public bool LowHighBet()
        {
            bool lowHigh;
            char input = 'n';
            while (input != 'L' || input != 'H')
            {
                Console.WriteLine("Would you like low or high? Enter l for low and h for high");
                input = char.Parse(Console.ReadLine());
                input = char.ToUpper(input);
            }
            if (input == 'E')
            {
                lowHigh = true;
            }
            else
            {
                lowHigh = false;
            }
            return lowHigh;
        }
        public int DozensBet()
        {
            int bet = 0;
            while (bet <= 0 || bet > 3)
            {
                try
                {
                    Console.WriteLine("Enter the dozen you would like to bet on " +
                        "(enter 1 for 1-12, enter 2 for 13-24, enter 3 for 25-36): ");
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
            return bet;
        }
        public int ColumnBet()
        {
            int bet = 0;
            while (bet <= 0 || bet > 3)
            {
                try
                {
                    Console.WriteLine("Enter the column you would like to bet on " +
                        "(enter 3 for the bottom column, enter 2 for middle column, enter 1 for the top column): ");
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
            return bet;
        }
        public int RowBet()
        {

            int bet = 0;
            while (bet <= 0 || bet > 12)
            {
                try
                {
                    Console.WriteLine("Enter the row you would like to bet on (use 1-12)");
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
            return bet;
        }
        public void DoubleRowBet(DoubleRows doubleRowBet)
        {
            int bet = 0;
            int bet2 = 12;
            while (bet <= 0 && bet > 12 && (bet + 1 == bet2 || bet - 1 == bet2))
            {
                try
                {
                    Console.WriteLine("Enter the row you would like to bet on (use 1-12)");
                    bet = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second row you would like to bet on (use 1-12, this row must be next to your first row)");
                    bet2 = int.Parse(Console.ReadLine());
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
            doubleRowBet.row1 = bet;
            doubleRowBet.row2 = bet2;
        }
        public void SplitBet(Split split)
        {
            int bet = 0;
            int bet2 = 37;
            while (bet <= 0 && bet > 36 && (Math.Abs(bet - bet2) <= 3 && Math.Abs(bet - bet2) != 2))
            {
                try
                {
                    Console.WriteLine("Enter the first number you would like to split");
                    bet = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number you would like to split");
                    bet2 = int.Parse(Console.ReadLine());
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
            split.number1 = bet;
            split.number2 = bet2;

        }
        public void CornerBet(Corner corner)
        {
            int num1=0, num2=0, num3=0, num4=0;
            do
            {
                try
                {
                    Console.WriteLine("Enter the first number of your corner");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number of your corner");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the third number of your corner");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the fourth number of your corner");
                    num4 = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please try again.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Please try again.");
                }
            } while (((num1 >= 1 && num1 <= 36) && (num2 >= 1 && num2 <= 36) && (num3 >= 1 && num3 <= 36) && (num4 >= 1 && num4 <= 36))
            && (Math.Abs(num1-num2)<=4 && Math.Abs(num1 - num3) <= 4 && Math.Abs(num1 - num4) <= 4 ));
            corner.number1 = num1;
            corner.number2 = num2;
            corner.number3 = num3;
            corner.number4 = num4;
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

    }
    public struct Dozen
    {
        public int dozen { get; }

    }
    public struct Columns
    {
        public int column { get; set; }

    }
    public struct Rows
    {
        public int row{ get; set; }

    }
    public struct DoubleRows
    {
        public int row1 { get; set; }
        public int row2 { get; set; }

    }
    public struct Split
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

    }
    public struct Corner
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
        public int number4 { get; set; }
    }

}
