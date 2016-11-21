using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2
{
    class Concordance
    {
        String text;
        int countRow;
        List<String> pages;
        List<String> rows;
        TextReader txtReader;
        SortedDictionary<String, String> conco;

        public Concordance(String PATH_CONCORDANCE_TEXT, int countRow)
        {
            conco = new SortedDictionary<String, String>();
            txtReader = new TextReader(PATH_CONCORDANCE_TEXT);
            text = txtReader.readerText();
            pages = new List<String>();
            rows = new List<String>();
            this.countRow = countRow;
        }

        public SortedDictionary<String, String> getDictionaryConco()
        {
            text = text.ToLower();
            String[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (String word in words)
            {
                if (!conco.ContainsKey(word))
                {
                    String urlPages = String.Empty;
                    int urlCount = 0;
                    for (int i = 0; i < pages.Count; i++)
                    {
                        Boolean flag = false;
                        String[] page = pages[i].Split(new char[] { ' ', ',', '.', ';', ':', '!', '?', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < page.Length; j++)
                        {
                            if (word.Equals(page[j].ToLower()))
                            {
                                urlCount++;
                                if (!flag)
                                {
                                    urlPages += " " + (i + 1) + " ";
                                    flag = true;
                                }
                            }
                        }
                    }
                    conco.Add(key: word, value: urlCount + ":" + urlPages);
                }
            }
            return conco;
        }

        public List<String> myPages(int countRows)
        {
            List<String> page = new List<String>();
            String[] arrayStrings = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            String pPage = String.Empty;
            int count = 0;
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                count++;
                pPage += arrayStrings[i] + "\n";
                if (count == countRows)
                {
                    pages.Add(pPage);
                    pPage = String.Empty;
                    count = 0;
                } else if (i == arrayStrings.Length - 1)
                {
                    pages.Add(pPage);
                    pPage = String.Empty;
                    count = 0;
                }
            }
            return pages;
        }
    }
}
