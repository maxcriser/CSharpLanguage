using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    class Candy : AbstractSweet
    {
        public int color { get; private set; }
        
        private Candy() { }

        public Candy(int Color)
        {
            percentOfSugar = 30;
            weight = 0.015;
            if (Color >= 0 || Color <= 0xFFFFFF)
            {
                this.color = Color;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return "Candy\nWeight " + weight + "g, percent of sugar " + percentOfSugar + "%"; 
        }
    }
}
