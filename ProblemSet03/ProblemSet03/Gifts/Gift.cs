using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSet03.Sweets;

namespace ProblemSet03
{
    class Gift
    {
        public List<AbstractSweet> Sweets { get; private set; }
        
        private Gift(List<AbstractSweet> sweets) 
        {
            Sweets = sweets;
        }

        public double GetWeight(){
            double weight = 0;
            foreach (var sweet in Sweets)
            {
                weight += sweet.weight;
            }
            return weight;
        }

        public double GetAveragePercentOfSugar()
        {
            double fullWeight = GetWeight();
            double averagePercent = 0;
            foreach (var sweet in Sweets)
            {
                averagePercent += (sweet.weight / fullWeight) * sweet.percentOfSugar;
            }
            return averagePercent;
        }

        public void SortByWeight()
        {
            Sweets.Sort(new WeigthComparer());
        }

        public void SortByPercentOfSugar()
        {
            Sweets.Sort(new PercentOfSugarComparer());
        }

        public class Builder
        {
            private List<AbstractSweet> Sweets = new List<AbstractSweet>();

            public Builder AddSweet(AbstractSweet sweet)
            {
                Sweets.Add(sweet);
                return this;
            }

            public Builder AddSweets(AbstractSweet[] sweets)
            {
                foreach(var sweet in sweets){
                    Sweets.Add(sweet);
                }
                return this;
            }

            public Builder AddSweets(List<AbstractSweet> sweets)
            {
                Sweets = sweets;
                return this;
            }

            public Gift Build()
            {
                Gift gift = new Gift(Sweets);
                return gift;
            }
        }

    }
}
