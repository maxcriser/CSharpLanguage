using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Set2
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"d:\text.txt";
            String fileNameC = @"d:\textC.txt";

            TextReader mTextReader = new TextReader(fileName);

            String text = mTextReader.readerText();

            TextHandler mTextHandler = new TextHandler(text);

            Dictionary<String, int> ourMap = new Dictionary<String, int>();
            ourMap = mTextHandler.getSentencesCountWords(mTextHandler.splitSentence());
            
            Console.WriteLine("1. Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них:\n");

            foreach (var pair in ourMap)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("\n2. Во всех вопросительных предложениях текста найти и напеча¬тать без повторений слова заданной длины:\n");

            Console.WriteLine("Введите длинну слова: ");
            int countCharacters = int.Parse(Console.ReadLine());
            HashSet<String> ourWords = mTextHandler.wordsCountCharacters(countCharacters);
            foreach (var word in ourWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n3. Из текста удалить все слова заданной длины, начинающиеся на согласную букву:\n");
            Console.WriteLine("Введите длинну слова: ");
            int secondCountCharacters = int.Parse(Console.ReadLine());
            String rText = mTextHandler.removeWordsCountCharacters(secondCountCharacters);
            Console.WriteLine("Исходный:\n" + text);
            Console.WriteLine("Результат:\n" + rText);

            Console.WriteLine("\n4. В некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которой может не совпадать с длиной слова:\n");
            Console.WriteLine("Введите длинну слова: ");
            int thirdCountCharacters = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите слово: ");
            String myReplaceWord = Console.ReadLine();
            String dText = mTextHandler.replaceWord(thirdCountCharacters, myReplaceWord);
            Console.WriteLine("Исходный:\n" + text);
            Console.WriteLine("Результат:\n" + dText);
            
            Console.WriteLine("\n5. Concordance:\n");
            int countRow;
            do
            {
                Console.WriteLine("Введите количество строк (стр): ");
                countRow = int.Parse(Console.ReadLine());
            } while (countRow < 1);
            Concordance mConcordance = new Concordance(fileNameC, countRow);
            List<String> listPages = mConcordance.myPages(countRow);

            for (int i = 0; i < listPages.Count; i++)
            {
                Console.WriteLine(listPages[i]);
            }

            SortedDictionary<String, String> ourConco = mConcordance.getDictionaryConco();
            String separator = ".................";
            foreach (var kvp in ourConco)
            {
                Console.WriteLine("{0}" + separator + "{1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();
        }
    }
}
