using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22072024_DicesChancesOfBecomingADuchess_CodersLife
{
    public class Dice
    {
        public const int SurfaceCount = 6;
        private static Random random = new Random();
        public int Roll()
        {
            return random.Next(1, SurfaceCount + 1);
        }
    }
}
