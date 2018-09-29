using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DisplayPossibleWinningBets
    {
        public void DisplayPossibleWins(SpinWheel spinWheel, Board[,] rouletteBoard)
        {
            Console.WriteLine($"\nYou could have won with the following bets");
            Console.WriteLine($"Specific number bet on: {rouletteBoard[spinWheel.winningColumn,spinWheel.winningRow].number}");
            if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].color=="B")
            {
                Console.WriteLine("Color bet: Black");
            }
            else
            {
                Console.WriteLine("Color bet: Red");
            }

            if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number%2==0)
            {
                Console.WriteLine("Even/Odd bet: Even");
            }
            else
            {
                Console.WriteLine("Even/Odd bet: odd");
            }
            if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number<=18)
            {
                Console.WriteLine("Low/High bet: Low");
            }
            else
            {
                Console.WriteLine("Low/High: High");
            }
            if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number<=12)
            {
                Console.WriteLine("Dozen: 1st dozen (1-12)");
            }
            else if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number>12 && rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number<=24)
            {
                Console.WriteLine("Dozen: 2nd dozen(13-24)");
            }
            else
            {
                Console.WriteLine("Dozen: 3rd dozen (25-36)");
            }
            if(spinWheel.winningColumn==0)
            {
                Console.WriteLine("Column: 1st column");
            }
            else if(spinWheel.winningColumn==1)
            {
                Console.WriteLine("Column: 2nd column");
            }
            else
            {
                Console.WriteLine("Column: 3rd column");
            }
            Console.WriteLine($"Row: {spinWheel.winningRow + 1}");
            Console.WriteLine($"Double Row: Either {spinWheel.winningRow + 2} and {spinWheel.winningRow + 1} or {spinWheel.winningRow} and {spinWheel.winningRow + 1}");

            if (spinWheel.winningRow == 0)
            {
                if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number % 3 == 0)
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                       $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                       $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                       $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}");
                }
                else if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number % 3 == 1)
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                      $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                      $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                      $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}");
                }
                else
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                      $"  and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                      $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                      $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1} or " +
                      $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1} and " +
                      $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}");
                }
            }
            else if (spinWheel.winningRow == 11)
            {
                if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number % 3 == 0)
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                       $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3} or " +
                       $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                       $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}");
                }

                else if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number % 3 == 1)
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                       $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3} or " +
                       $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                       $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}");
                }
                else
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                     $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3} or " +
                     $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                     $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1} or " +
                     $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                     $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-1}");
                }
            }
            else
            {
                if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number % 3 == 0)
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                        $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                        $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3} or " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}");
                }
                else if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number % 3 == 1)
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                        $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                        $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3} or " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}");
                }
                else
                {
                    Console.WriteLine($"Split bet combinations: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}" +
                        $" and {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3} or " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1} or" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} and " +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}");
                }
            }

            if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number <= 3)
            {
                if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number == 3)
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3}");
                }
                else if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number == 2)
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +

                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 4}");
                }
                else
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 4}");
                }
            }
            else if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number >= 34)
            {
                if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number == 36)
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 4}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number -1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}");
                }
                else if (rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number == 35)
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 4}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number -1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number } or " +

                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number -2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}");
                }
                else
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number -2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}");
                }
            }
            else
            {
                if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number %3==0)
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3} or " +
                        
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 4}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} ");
                }
                else if(rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number %3==1)
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1} or " +

                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number +1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number+3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number+4} ");
                }
                else
                {
                    Console.WriteLine($"Corner bet: {rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1} or " +

                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number + 4} or " +
                        
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number-4}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number -3}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number -1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number} or " +
                        
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number - 1}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number +2}/" +
                        $"{rouletteBoard[spinWheel.winningColumn, spinWheel.winningRow].number+3}");
                }
            }

        }
        //for determining columns that could win use %3 1st column ==.3 2nd column =.66 3rd column == 0
        //for winning rows %3==0 then subtract 1 and 2 to find the other two numbers
            //if .66 add one and subtract 1
            //if .33 add one and 2
        //low high if num <=18 =>36 high
        //dozens if num 1-12, 13-24-25-36
        //for split bets 
        //for corner bets 
    }
}
