using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Disc
    {
        public String name { get; set; }
        public String state { get; set; }
        public String who { get; set;  }

        public Disc(String name, String state, String who)
        {
            this.name = name;
            this.state = state;
            this.who = who;
        }

        public override string ToString()
        {
            return name + "(" + state + ")" + who;
        }
    }
}
