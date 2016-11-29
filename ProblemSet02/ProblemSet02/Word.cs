using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class Word : ElementOfText, IComparable
    {
        public List<Symbol> WordAsList = new List<Symbol>();

        public Word(string w)
        {
            foreach (var ch in w)
            {
                WordAsList.Add(new Symbol(ch));
            }
        }

        public override string ConsoleOutputStructure()
        {
            string sWord = "\n------>(Word ";
            foreach (var element in WordAsList)
            {
                sWord += element.ConsoleOutputStructure();
            }
            return sWord + "\n<------)";
        }

        public override string ToString()
        {
            string sWord = "";
            foreach (var symbol in WordAsList)
            {
                sWord += symbol.ToString();
            }
            return sWord;
        }

        public int getNumberOfSymbols()
        {
            return this.WordAsList.Count;
        }

        public int CompareTo(Object obj)
        {
            Word w = obj as Word;
            if (w == null) throw new ArgumentException();
            return this.getNumberOfSymbols().CompareTo(w.getNumberOfSymbols());
        }

        public bool StartsWithConsonant()
        {
            return WordAsList[0].IsConsonant();
        }

        public int GetLength(){
            return WordAsList.Count;
        }
    }
}
