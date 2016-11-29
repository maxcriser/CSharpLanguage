using ProblemSet03.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03
{
    class WeigthComparer : IComparer<AbstractSweet>
    {
        public int Compare(AbstractSweet s1, AbstractSweet s2)
        {
            if (s1.weight < s2.weight)
            {
                return -1;
            }
            else if (s1.weight > s2.weight)
            {
                return 1;
            } else return 0;
        }
    }
}
