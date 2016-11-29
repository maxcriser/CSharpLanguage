using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Disc
    {
        public String name { get; private set; }
        public String state { get; private set; }

        public Disc(String name, String state)
        {
            this.name = name;
            this.state = state;
        }

        public override string ToString()
        {
            return name + "(" + state + ")";
        }
    }
}
