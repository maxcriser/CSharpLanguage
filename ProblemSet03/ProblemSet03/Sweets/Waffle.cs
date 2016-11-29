using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    class Waffle : AbstractSweet
    {
        public Waffle()
        {
            weight = 0.030;
            percentOfSugar = 35;
        }

        public override string ToString()
        {
            return "Waffle\nWeight " + weight + "g, percent of sugar " + percentOfSugar + "%";
        }
    }
}
