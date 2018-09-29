using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class SpinWheel
    {
        Random rng;
        public int winningRow { set; get; }
        public int winningColumn { get; set; }
        public SpinWheel(Random rng)
        {
            this.rng = rng;
        }
        public void Spin()
        {
            winningRow = rng.Next(3);
            winningColumn = rng.Next(12);
        }
    }
}
