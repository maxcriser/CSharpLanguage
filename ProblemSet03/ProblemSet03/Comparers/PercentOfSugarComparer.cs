using ProblemSet03.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03
{
    class PercentOfSugarComparer : IComparer<AbstractSweet>
    {
        public int Compare(AbstractSweet s1, AbstractSweet s2)
        {
            if (s1.percentOfSugar < s2.percentOfSugar)
            {
                return -1;
            }
            else if (s1.percentOfSugar > s2.percentOfSugar)
            {
                return 1;
            }
            else return 0;
        }
    }
}
