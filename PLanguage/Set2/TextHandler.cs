using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Set2
{
    class TextHandler
    {
        string text;
        string removeText;
        string mReplaceText;
        List<String> sent;
        List<String> qSentences;
        Dictionary<String, int> map;
        HashSet<Char> consonants;
        public TextHandler(String text)
        {
            this.text = text;
            sent = new List<String>();
            consonants = new HashSet<Char>();
            consonants.Add('б');
            consonants.Add('в');
            consonants.Add('г');
            consonants.Add('д');
            consonants.Add('ж');
            consonants.Add('з');
            consonants.Add('й');
            consonants.Add('к');
            consonants.Add('л');
            consonants.Add('м');
            consonants.Add('н');
            consonants.Add('п');
            consonants.Add('р');
            consonants.Add('с');
            consonants.Add('т');
            consonants.Add('ф');
            consonants.Add('х');
            consonants.Add('ц');
            consonants.Add('ч');
            consonants.Add('ш');
            consonants.Add('щ');
        }

        public List<String> getQSent()
        {
            List<String> qSent = new List<String>();
            foreach (String ourSent in sent)
            {
                if (ourSent.EndsWith("?"))
                    qSent.Add(ourSent);
            }
            return qSent;
        }
        
        public String replaceWord(int countChar, String mReplacedWord)
        {
            mReplaceText = text;
            foreach (string word in mReplaceText.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (word.Length == countChar)
                {
                    int start = mReplaceText.IndexOf(word);
                    try
                    {
                        mReplaceText = mReplaceText.Remove(start, word.Length);
                        mReplaceText = mReplaceText.Insert(start, mReplacedWord);
                    }
                    catch
                    {
                        // ну бывает
                    }
                }

            }
            return mReplaceText;
        }

        public String removeWordsCountCharacters(int countChar)
        {
            removeText = text;
            foreach (string word in removeText.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (word.Length == countChar && consonants.Contains(word[0]))
                {
                    int start = removeText.IndexOf(word);
                    try {
                        removeText = removeText.Remove(start, word.Length);
                    }
                    catch
                    {
                        // ну бывает
                    }
                }
            }
            return removeText; 
        }

        public HashSet<String> wordsCountCharacters(int countChar)
        {
            HashSet<String> words = new HashSet<String>();
            qSentences = getQSent();

            for (int i = 0; i < qSentences.Count; i++)
            {
                foreach (string word in qSentences[i].Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
                    if (word.Length == countChar)
                        words.Add(word);
            }
            return words;
        }

        public List<String> textToList(String[] text)
        {
            List<String> listText = new List<String>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != "") listText.Add(text[i]);
            }
            return listText;
        }

        public String[] sentencesWithPunct(char ch)
        {
            String[] sentences;

            sentences = text.Split(ch);

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] += ch;
            }
            return sentences;
        }



        public List<String> splitSentence()
        {
            String[] sentences;

            sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
            }

            List<String> listSentences = new List<String>();
            listSentences = textToList(sentences);
            sent = listSentences;

            return listSentences;
        }

        public Dictionary<String, int> getSentencesCountWords(List<String> sentences)
        
            map = new Dictionary<String, int>();

            for (int i = 0; i < sentences.Count; i++)
            {
                map.Add(key: sentences[i], value: countWordsInSentence(sentences[i]));
            }

            var ordered = map.OrderBy(x => x.Value);
            return ordered.ToDictionary(t => t.Key, t => t.Value);
        }

        public int countWordsInSentence(String sen)
        {
            String[] words = sen.Split(' ');
            return words.Length;
        }
    }
}
