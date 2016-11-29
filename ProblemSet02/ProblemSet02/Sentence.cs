using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProblemSet02
{
    class Sentence : ElementOfText, IComparable
    {
        public List<ElementOfText> ListSentence = new List<ElementOfText>();
        private string pattern = @"(?<=[ .,!?:;\-\n])";
        public static char[] Delimeters = {'.', '!', '?'};
        private int numberOfWords = 0;

        public Sentence(string s)
        {
            foreach (var element in Regex.Split(s, pattern))
            {
                if (element != string.Empty)
                {
                    Punct pMark = null;
                    Word word = null;
                    if (element.Length == 1)
                    {
                        pMark = new Punct(element[0]);
                    } else
                    {
                        word = new Word(element.Substring(0, element.Length-1));
                        numberOfWords++;
                        pMark = new Punct(element[element.Length - 1]);
                    }
                    if (word != null) ListSentence.Add(word);
                    if (pMark != null) ListSentence.Add(pMark);
                }
            }
        }

        public int getNumberOfWords(){
            return numberOfWords;
        }

        public int CompareTo(Object obj)
        {
            Sentence s = obj as Sentence;
            if (s == null) throw new ArgumentException();
            int num = s.getNumberOfWords();
            return this.numberOfWords.CompareTo(num);
        }

        public override string ConsoleOutputStructure()
        {
            string sSentence = "\n--->Sentence: ";
            foreach (var element in ListSentence)
            {                
                sSentence += element.ConsoleOutputStructure();
            }
            return sSentence + "\n---)";
        }

        public bool IsQSentence()
        {
            if (ListSentence[ListSentence.Count - 1].ToString().Equals("?"))
            {
                return true;
            }
            else return false;
        }

        public List<Word> GetWordsWithLength(int length)
        {
            List<Word> listOfWords = new List<Word>();
            foreach (var element in ListSentence)
            {
                Word word = element as Word;
                if (word != null)
                {
                    if (word.ToString().Length == length)
                    {
                        listOfWords.Add(word);
                    }
                }
            }
            return listOfWords;
        }

        public override string ToString()
        {
            string pSentence = String.Empty;
            foreach (var element in ListSentence) {
                pSentence += element.ToString();
            }
            return pSentence;
        }

        public void DeleteWordsWithLength(int length)
        {
            int index = 0;
            List<int> deleteIndexies = new List<int>();
            foreach (var element in ListSentence)
            {
                Word word = element as Word;
                if (word != null)
                {
                    if (word.StartsWithConsonant() && word.GetLength() == length)
                    {
                        deleteIndexies.Add(index);
                    }
                }
                index++;
            }
            index = 0;
            foreach (var deleteIndex in deleteIndexies)
            {
                ListSentence.RemoveAt(deleteIndex-index);
                index++;
            }
        }

        public void ReplaceWord(int wordLength, string replacedStr)
        {
            int index = 0;
            List<int> replaceIndexies = new List<int>();
            foreach (var element in ListSentence)
            {
                Word word = element as Word;
                if (word != null)
                {
                    if (word.GetLength() == wordLength)
                    {
                        replaceIndexies.Add(index);
                    }
                }
                index++;
            }

            foreach (var replaceIndex in replaceIndexies)
            {
                ListSentence.RemoveAt(replaceIndex);
                ListSentence.Insert(replaceIndex, new Word(replacedStr));
            }
        }
    }
}
