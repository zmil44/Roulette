using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public struct Board
    {
        public int number;
        public string color { get; }

        public Board(int number, string color)
        {
            this.number = number;
            this.color = color;
        }
    }
}
