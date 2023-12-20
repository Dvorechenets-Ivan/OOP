using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lab_3_zav_1
{
    class Program
    {
        static void Main()
        {
            File[] Files = new File[20];
            int choice;
            do
            {
                Console.WriteLine("Як бажаєте заповнити масив");
                Console.WriteLine("Для виконання випадковим чином введіть 1");
                Console.WriteLine("Для виконання вручну введіть 2");
                Console.WriteLine("Для виходу з програми введіть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (int i = 10; i < 30; i++)
                        {
                            string filename = i + ".txt";
                            File textFile = new File(filename);
                            Random random = new Random();
                            string randomText1 = File.GenerateRandomText(random, 2, "123456789");
                            string randomText2 = File.GenerateRandomText(random, 2, "123456789");

                            textFile.WriteText(randomText1, randomText2);
                            Files[i - 10] = textFile;
                            Console.WriteLine($"Created and populated file {filename}");
                        }
                        Console.WriteLine("All files created and populated successfully."); ;
                        break;
                    case 2:
                        for (int i = 10; i <= 29; i++)
                        {
                            string filename = $"{i}.txt";
                            File textFile = new File(filename);
                            string fileData = textFile.ReadText();
                            Files[i - 10] = textFile;
                        }
                        break;
                    case 3:
                        double Product = File.Calculate(Files);
                        Console.WriteLine($"Середнє арифметичне добутків: {Product}");
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
}
