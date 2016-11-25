using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qnote
{
    class Note
    {
        public String text;
        public Boolean favourite;
        public Boolean done;

        public Note(String text, Boolean favourite, Boolean done)
        {
            this.text = text;
            this.favourite = favourite;
            this.done = done;
        }
    }
}