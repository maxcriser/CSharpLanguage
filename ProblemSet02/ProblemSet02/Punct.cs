using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class PunctuationMark : TextElement
    {
        public char character;
        public static char[] Delimeters = {' ', '.', ',', ':', ';', '!', '?', '-', '\n'};

        public PunctuationMark(char c)
        {
            this.character = c;
        }

        public static bool IsPunctuationMark(char c){
            if (Delimeters.Contains(c))
            {
                return true;
            }
            else return false;
        }

        public override string ConsoleOutputStructure()
        {
            return "\n------>(PM " + (character == '\n' ? "'EndOfLine'" : "'" + character + "'") + ")";
        }


        public override string ToString()
        {
            return "" + this.character;
        }
    }
}
