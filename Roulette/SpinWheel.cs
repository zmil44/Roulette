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
        public int winningBin { set; get; }
        public SpinWheel(Random rng)
        {
            this.rng = rng;
        }
        public void Spin()
        {
            winningBin = rng.Next(37);
        }
    }
}
