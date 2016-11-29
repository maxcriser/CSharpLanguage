using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    class Chocolate : AbstractSweet
    {
        public ChocolateBar[] bars = new ChocolateBar[12];
        public Filling ChocolateFilling { get; private set; }
        public enum ChocolateType { Milky, Bitter };
        public ChocolateType Type { get; private set; }

        private Chocolate() { }

        public Chocolate(ChocolateType type, Filling filling)
        {
            Type = type;
            ChocolateFilling = filling;
            for (int i = 0; i < 12; i++)
            {
                bars[i] = new ChocolateBar(type, filling);
            }
            foreach (var bar in bars)
            {
                weight += bar.weight;
            }
            percentOfSugar = bars[0].percentOfSugar;
        }

        public string ChocolateTypeToString(ChocolateType type){
            if(type == ChocolateType.Milky){
                return "milky";
            } else if(type == ChocolateType.Bitter){
                return "bitter";
            } else {
                return "";
            }
        }

        public override string ToString()
        {
            return "Chocolate " + ChocolateTypeToString(Type) + " with " + FillingToString(ChocolateFilling) + "\nWeight " + weight + "g, percent of sugar " + percentOfSugar + "%";
        }
    }
}
