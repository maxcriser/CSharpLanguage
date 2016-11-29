using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    class Cookie : AbstractSweet
    {
        private Cookie() { }
        public HashSet<Filling> Fillings { get; private set; }

        public Cookie(HashSet<Filling> fillings)
        {
            Fillings = new HashSet<Filling>(fillings);
            weight = 0.020;
            percentOfSugar = 20;
            foreach(var filling in Fillings){
                if(filling == Filling.Nut){
                    weight += 0.002;
                } else if(filling == Filling.Fudge){
                    weight += 0.004;
                    percentOfSugar += 3;
                }
                else if (filling == Filling.Chocolate)
                {
                    weight += 0.003;
                    percentOfSugar += 2;
                }
            }
        }

        public string FillingsToString()
        {
            string s = "";
            foreach (var filling in Fillings)
            {
                s += FillingToString(filling) + " ";
            }
            return s;
        }

        public override string ToString()
        {
            return "Cookie with fillings: " + FillingsToString() + "\nWeight " + weight + "g, percent of sugar " + percentOfSugar + "%";
        }
    }
}
