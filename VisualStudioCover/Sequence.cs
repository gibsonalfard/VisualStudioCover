using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioCover
{
    public class Sequence
    {
        public int seq1(int x)
        {
            return x + 7;
        }

        public int seq2(int x, int y)
        {
            int result = (2 * x * x);
            result += (3 * y);
            result += 7;

            return result;
        }

        public bool seq3(int x, int y)
        {
            return x > y;
        }

        public bool seq4(int x, int y)
        {
            return !(x < 5 && y > 2);
        }
    }
}
