using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class Symbol : TextElement
    {
        public char character;
        private char[] vowels = {'a', 'e', 'u', 'y', 'o', 'i', 'A', 'E', 'U', 'Y', 'O', 'I'};

        public Symbol(char c){
            this.character = c;
        }

        public override string ConsoleOutputStructure()
        {
            return "\n------>(Symbol " + character + ")";
        }

        public override string ToString()
        {
            return "" + this.character;
        }

        public bool IsConsonant()
        {
            return !vowels.Contains(character);
        }
    }
}
