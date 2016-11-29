using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class Concordance
    {
        public int NumberOfOccurences = 0;
        public HashSet<int> NumbersOfLines = new HashSet<int>();

        public void AddOccurence(int line)
        {
            NumberOfOccurences++;
            NumbersOfLines.Add(line);
        }

        public override string ToString()
        {
            string resultStr = "";
            for (int i = 0; i < NumbersOfLines.Count; i++)
            {
                resultStr += NumbersOfLines.ElementAt(i);
                if (i != NumbersOfLines.Count - 1)
                {
                    resultStr += ", ";
                }
            }
            return NumberOfOccurences + " time" + ((NumberOfOccurences == 1) ? "" : "s") + " in " +
                   resultStr + " sentence" + ((NumbersOfLines.Count == 1) ? "" : "s");
        }
    }
}
