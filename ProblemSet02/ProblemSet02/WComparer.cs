using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class WComparer : IEqualityComparer<Word>
    {
        public bool Equals(Word cur, Word next)
        {
            if (cur.ToString().Equals(next.ToString())) return true;
            else return false;
        }

        public int GetHashCode(Word word)
        {
            return word.ToString().GetHashCode();
        }
    }
}