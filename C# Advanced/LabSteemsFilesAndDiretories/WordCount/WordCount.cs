namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var wordsList = new Dictionary<string, int>();

            var wordsReader = new StreamReader(wordsFilePath);
            var textReader = new StreamReader(textFilePath);

            using (wordsReader)
            {
                while (true)
                {
                    string line = wordsReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] currentLine = line.Split();
                    foreach (var word in currentLine)
                    {
                        wordsList.Add(word, 0);
                    }
                }
            }
            using (textReader)
            {
                while (true)
                {
                    string line = textReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] currentLine = new string(line
                        .ToLower()
                        .Where(x => Char.IsLetter(x) || Char.IsWhiteSpace(x))
                        .ToArray())
                        .Split();

                    foreach (var item in currentLine)
                    {
                        if (wordsList.ContainsKey(item))
                        {
                            wordsList[item]++;
                        }
                    }
                }
            }

            var writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                foreach (var item in wordsList.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
