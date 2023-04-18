using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04._2023_Progetto_Pasqua
{
    class CBird: IComparable<CBird>
    {
        static int globalnumber = 0;

        public int Weight { get; }
        public int Number { get; }

        public CBird(int weight)
        {
            Weight = weight;
            Number = globalnumber;

            globalnumber++;
        }

        public int CompareTo(CBird other)
        {
            return Weight.CompareTo(other.Weight);
        }
    }
}
