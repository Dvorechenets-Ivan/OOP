using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lab_3_zav_1
{
    public class File 
    {
        private string filename;
        private int num1;
        private int num2;

        public File(string fileName)
        {
            filename = fileName;
        }

        public int Num1
        {
            get 
            { 
                return num1; 
            }
            set 
            { 
                num1 = value; 
            }
        }
        public int Num2
        {
            get 
            { 
                return num2; 
            }
            set 
            { 
                num2 = value; 
            }
        }
        
        public void WriteText(string text1, string text2)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(text1);
                    writer.WriteLine(text2);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Помилка при записі в файл '{filename}': {e.Message}");
            }
        }
        public static string GenerateRandomText(Random random, int length, string amount)
        {
            char[] randomText = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomText[i] = amount[random.Next(amount.Length)];
            }
            return new string(randomText);
        }
        public string ReadText()
        {
            string line1 = null;
            string line2 = null;
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    line1 = reader.ReadLine();
                    line2 = reader.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Помилка, файл '{filename}' відсутній: {e.Message}");
                File.AppendAllText("no_file.txt", filename + "\n");
                return null;
            }
            catch (IOException e)
            {
                Console.WriteLine($"Помилка при зчитуванні з файлу '{filename}': {e.Message}");
                return null;
            }

            try
            {
                int parsedNum1 = int.Parse(line1);
                int parsedNum2 = int.Parse(line2);
                Num1 = parsedNum1;
                Num2 = parsedNum2;
                string result = $"{Num1}\n{Num2}";
                Console.WriteLine($"Успішно прочитано два числа з файлу '{filename}'");
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Помилка у файлі '{filename}': перший або другий рядок не містить два цілих числа.");
                File.AppendAllText("bad_data.txt", filename + "\n");
                return null;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Помилка у файлі '{filename}': переповнення значення при перетворенні рядка на ціле число.");
                File.AppendAllText("overflow.txt", filename + "\n");
                return null;
            }
        }
        public static double Calculate(File[] textFiles)
        {
            long totalProduct = 0;
            int numFilesWithValidData = 0;
            foreach (var textFile in textFiles)
            {
                int num1 = textFile.Num1;
                int num2 = textFile.Num2;
                try
                {
                    checked
                    {
                        int product = num1 * num2;
                        totalProduct += product;
                        numFilesWithValidData++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переповнення значення при обчисленні добутку.");
                }
            }

            try
            {
                double averageProduct = (double)totalProduct / numFilesWithValidData;
                return averageProduct;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: ділення на нуль.");
                return 0;
            }
        }

        private static void AppendAllText(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
