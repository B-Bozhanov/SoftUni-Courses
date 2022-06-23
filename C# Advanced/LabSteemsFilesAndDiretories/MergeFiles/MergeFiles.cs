namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string inputFile1, string inputFile2, string outputFile)
        {
            using var file1 = new StreamReader(inputFile1);
            using var file2 = new StreamReader(inputFile2);
            using var writer = new StreamWriter(outputFile);

            while (true)
            {
                string file1Line = file1.ReadLine();
                string file2Line = file2.ReadLine();

                if (file1Line == null && file2Line == null)
                {
                    break;
                }

                if (file1Line == null && file2Line != null)
                {
                    file2Line = NewMethod(file2, writer, file2Line);
                    break;
                }
                if (file1Line != null && file2Line == null)
                {
                    while (file1Line != null)
                    {
                        writer.WriteLine(file1Line);
                        file1Line = file1.ReadLine();
                    }
                    break;
                }

                writer.WriteLine(file1Line);
                writer.WriteLine(file2Line);
            }
        }

        private static string NewMethod(StreamReader file2, StreamWriter writer, string file2Line)
        {
            while (file2Line != null)
            {
                writer.WriteLine(file2Line);
                file2Line = file2.ReadLine();
            }

            return file2Line;
        }
    }
}
