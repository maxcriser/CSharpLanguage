using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    abstract class AbstractSweet
    {
        public enum Filling { Nut, Fudge, Chocolate, None };
        public double percentOfSugar { get; protected set; }
        public double weight { get; protected set; }

        public string FillingToString(Filling filling)
        {
            if (filling == Filling.Chocolate) {
                return "chocolate";
            } else if (filling == Filling.Nut) {
                return "nut";
            }
            else if (filling == Filling.Fudge)
            {
                return "fudge";
            } else {
                return "";
            }
        }
    }
}
