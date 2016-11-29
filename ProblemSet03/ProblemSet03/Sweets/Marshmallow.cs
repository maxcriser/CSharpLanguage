using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    class Marshmallow : AbstractSweet
    {
        public enum Flavors
        {
            Banana,
            Orange,
            Strawberry,
            Vanilla,
            Lemon
        }
        public Flavors Flavor;

        private Marshmallow() { }

        public Marshmallow(Flavors flavor)
        {
            if(flavor == null)throw new ArgumentException();
            Flavor = flavor;
            weight = 0.015;
            percentOfSugar = 40;
            switch (Flavor)
            {
                case Flavors.Banana:
                case Flavors.Orange:
                case Flavors.Strawberry:
                    percentOfSugar += 5;
                    break;
                case Flavors.Lemon:
                    percentOfSugar += 2;
                    break;
            }
        }

        public string FlavorToString(Flavors flavor){
            switch (flavor)
            {
                case Flavors.Banana:
                    return "banana";
                case Flavors.Orange:
                    return "orange";
                case Flavors.Strawberry:
                    return "strawberry";
                case Flavors.Lemon:
                    return "lemon";
                case Flavors.Vanilla:
                    return "vanilla";
                default:
                    return "";
            }
        }

        public override string ToString()
        {
            return "Marshmallow with " + FlavorToString(Flavor) + "\nWeight " + weight + "g, percent of sugar " + percentOfSugar + "%";
        }
    }
}
