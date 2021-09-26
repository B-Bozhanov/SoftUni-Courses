using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOne = int.Parse(Console.ReadLine());
            int NumTwo = int.Parse(Console.ReadLine());

            //2345
            //6789

           string a1 = NumOne.ToString();
           string a2 = NumTwo.ToString();
            for (int i = a1[3]; i <= a2[3]; i++)
            {
                int b1 = Int32.Parse(i.ToString());
                for (int j = a1[2]; j <= a2[2]; j++)
                {
                    int b2 = Int32.Parse(j.ToString());
                    for (int k = a1[1]; k <= a2[1]; k++)
                    {
                        int b3 = Int32.Parse(k.ToString());
                        for (int l = a1[0]; l <= a2[0]; l++)
                        {
                          int b4 = Int32.Parse(l.ToString());
                            if (b1 % 2 != 0 && b2 % 2 != 0 && b3 % 2 != 0 && b4 % 2 != 0)
                            {
                                Console.WriteLine($"{b1}{b2}{b3}{b4}");
                            }
                        }
                    }
                }
            }        
            //int firstDigit = NumOne % 10;
            //NumOne /= 10;
            //int secondDigit = NumOne % 10;
            //NumOne /= 10;
            //int thithDigit = NumOne % 10;
            //int fourthDigit = NumOne / 10;

            //int firstDigit1 = NumTwo % 10;
            //NumTwo /= 10;
            //int secondDigit2 = NumTwo % 10;
            //NumTwo /= 10;
            //int thithDigit3 = NumTwo % 10;
            //int fourthDigit4 = NumTwo / 10;

            //for (int i = fourthDigit; i <= fourthDigit4; i++)
            //{
            //    for (int j = thithDigit; j <= thithDigit3; j++)
            //    {
            //        for (int k = secondDigit; k <= secondDigit2; k++)
            //        {
            //            for (int l = firstDigit; l <= firstDigit1; l++)
            //            {
            //                if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
            //                {
            //                    Console.Write($"{i}{j}{k}{l} ");
            //                }
            //            }
            //        }
            //    }
            //}

        }
    }
}
