using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2
{
    class TextHandler
    {
        String text;

        public TextHandler(String text)
        {
            this.text = text;
        }

        public List<String> textToList(String[] text)
        {
            List<String> listText = new List<String>();
          
            for(int i=0; i<text.Length; i++)
            {
                if(text[i] != "") listText.Add(text[i]);
            }
            return listText;
        }

        public String[] sentencesWithPunct(char ch)
        {
            String[] sentences;

            sentences = text.Split(ch);

            for(int i=0; i<sentences.Length;i++)
            {
                sentences[i] += ch;
            }
            return sentences;
        }

        public List<String> splitSentence()
        {
            String[] sentences;

            sentences = text.Split('!', '?', '.');

            for(int i=0; i<sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
            }

            List<String> listSentences = new List<String>();
            listSentences = textToList(sentences);
           
            return listSentences;
        }

        public Dictionary<String, int> getSentencesCountWords(List<String> sentences)
        {
            Dictionary<String, int> map = new Dictionary<String, int>();

            for(int i = 0; i<sentences.Count; i++)
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
