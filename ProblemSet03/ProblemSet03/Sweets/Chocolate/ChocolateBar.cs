using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Sweets
{
    class ChocolateBar : AbstractSweet
    {
        public Filling ChocolateFilling { get; private set; }
        public Chocolate.ChocolateType Type { get; private set; }
        private ChocolateBar() { }

        public ChocolateBar(Chocolate.ChocolateType type, Filling filling)
        {
            Type = type;
            ChocolateFilling = filling;
            percentOfSugar = 15;
            if (type == Chocolate.ChocolateType.Milky)
            {
                percentOfSugar += 10;
            }
            else if (type == Chocolate.ChocolateType.Bitter)
            {
                percentOfSugar -= 10;
            }
            else
            {
                throw new ArgumentException();
            }

            if (filling == Filling.Nut)
            {
                weight += 0.003;
            }
            else if (filling == Filling.Fudge)
            {
                weight += 0.001;
                percentOfSugar += 3;
            } else {
                throw new ArgumentException();
            }
        }
    }
}
