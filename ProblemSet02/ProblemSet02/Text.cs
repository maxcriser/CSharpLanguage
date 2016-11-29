using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProblemSet02
{
    class Text : IComparable
    {
        public List<Sentence> Sentences = new List<Sentence>();
        private string pattern = @"(?<=[.?!])";

        public Text(string t)
        {
            foreach (var element in Regex.Split(t, pattern))
            {
                if (element != string.Empty)
                {
                    Sentences.Add(new Sentence(element.Trim()));
                }
            }
        }

        private string getText(List<Sentence> sentences)
        {
            string pText = String.Empty;
            int numSentence = 0;
            foreach (var sentence in sentences)
            {
                pText += sentence.ToString();
                numSentence++;
                if (numSentence != sentences.Count)
                {
                    pText += " ";
                }
            }
            return pText;
        }

        public override string ToString()
        {
            return getText(this.Sentences);
        }

        public int CompareTo(Object obj)
        {
            Text t = obj as Text;
            if (t == null) throw new ArgumentException();
            return this.Sentences.Count.CompareTo(t.Sentences.Count);
        }

        public string SortedText()
        {
            //sort by wrds
            List<Sentence> sortSenteces = new List<Sentence>(Sentences);
            sortSenteces.Sort();
            return getText(sortSenteces);
        }

        public HashSet<Word> GetHashSetWordsLength(int length)
        {
            HashSet<Word> setWords = new HashSet<Word>(new WComparer());
            List<Sentence> questinSentences = this.GetQuestionSentences();
            foreach (var sentence in questinSentences)
            {
                List<Word> wordsInSentence = sentence.GetWordsWithLength(length);
                foreach (var word in wordsInSentence)
                {
                    setWords.Add(word);
                }
            }
            return setWords;
        }

        public void DeleteWordsWithLength(int length)
        {
            foreach (var sentence in Sentences)
            {
                sentence.DeleteWordsWithLength(length);
            }
        }

        public List<Sentence> GetQuestionSentences()
        {
            List<Sentence> setQSentences = new List<Sentence>();
            foreach (var sentence in Sentences)
            {
                if (sentence.IsQSentence())
                {
                    setQSentences.Add(sentence);
                }
            }
            return setQSentences;
        }

        public string DebugOfEntity()
        {
            string sText = "(Text ";
            foreach (var sentence in Sentences)
            {
                sText += sentence.ConsoleOutputStructure();
            }
            sText += ")";
            return sText;
        }

        public void ReplaceWord(int sentenceNum, int wordLength, string replacedStr)
        {
            if (sentenceNum < 0 || sentenceNum >= Sentences.Count || wordLength < 0) throw new ArgumentException();
            Sentences[sentenceNum].ReplaceWord(wordLength, replacedStr);
        }

        public Dictionary<string, Concordance> GetStatistics()
        {
            Dictionary<string, Concordance> stats = new Dictionary<string, Concordance>();
            int currentLine = 1;
            foreach (var sentence in Sentences)
            {
                foreach (var element in sentence.ListSentence)
                {
                    Word word = element as Word;
                    Punct pMark = element as Punct;
                    if (word != null)
                    {
                        if (!stats.ContainsKey(word.ToString()))
                        {
                            stats.Add(word.ToString(), new Concordance());
                        }
                        stats[word.ToString()].NumberOfOccurences++;
                        stats[word.ToString()].NumbersOfLines.Add(currentLine);
                    }
                    if (pMark != null && pMark.ToString().Equals("\n"))
                    {
                        currentLine++;
                    }
                }
            }
            return stats;
        }
    }
}
