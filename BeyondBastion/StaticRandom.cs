using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion
{
    public static class StaticRandom
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static double Double()
        {
            lock (syncLock)
            {
                return random.NextDouble();
            }
        }
    }
}
