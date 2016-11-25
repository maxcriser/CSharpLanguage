using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qnote
{
    class SortDone : Comparer<Note>
    {
        public override int Compare(Note cur, Note next)
        {
            int curDone = 0;
            int nextDone = 0;
            if (cur.done)
                curDone = 100;
            if (next.done)
                nextDone = 100;

            if (curDone < nextDone) return -1;
            else if (curDone > nextDone) return 1;
            else return 0;
        }
    }
}
