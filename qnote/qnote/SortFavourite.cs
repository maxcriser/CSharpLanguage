using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qnote
{
    class SortFavourite : Comparer<Note>
    {
        public override int Compare(Note cur, Note next)
        {
            int curFavourite = 0;
            int nextFavourite = 0;
            if (cur.favourite)
                curFavourite = 100;
            if (next.favourite)
                nextFavourite = 100;

            if (curFavourite > nextFavourite) return -1;
            else if (curFavourite < nextFavourite) return 1;
            else return 0;
        }
    }
}
