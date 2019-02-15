using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kod
            //Diary diary = new Diary();


            //try
            //{
            //    Console.WriteLine("Proszę podaj imię");
            //    diary.Name = Console.ReadLine();
            //}

            //catch (ArgumentException ae)
            //{
            //    Console.WriteLine("WPROWADZIŁEŚ NIEPOPRAWNĄ WARTOŚĆ");
            //    Console.WriteLine(ae.Message);
            //}
            //catch (NullReferenceException nre)
            //{
            //    Console.WriteLine("coś poszło nie tak");
            //    Console.WriteLine(nre.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("generalny wyjatek");
            //    Console.WriteLine(e.Message);
            //}

            //diary.NameChanged +=  OnNameChanged;
            //diary.NameChanged +=  OnNameChanged2;
            //diary.NameChanged +=  OnNameChanged3;
            //diary.NameChanged +=  OnNameChanged3;
            //diary.NameChanged +=  OnNameChanged3;
            //diary.NameChanged -= OnNameChanged3;
            //diary.NameChanged -= OnNameChanged3;

            ////diary.AddRating(3f);
            ////diary.AddRating(3.5f);
            ////diary.AddRating(4f);
            ////diary.AddRating(5f);

            ////DiaryStatistics stats = diary.ComputStatistics();


            ////WriteReslt("Najniższa", (long)stats.MinGrade, 2);
            ////WriteReslt("Najwyższa", (int)stats.MaxGrade);
            ////WriteReslt("Średnia", stats.AverageGrade, 2, 5 ,6 ,7);
            ////WriteReslt("Najniższa", (long)stats.MinGrade);

            //diary.Name = "Dzienniczek Marcina";
            //diary.Name = "Nowy dzienniczek Marcina";

            //diary.Name = null;
            //diary.Name = "";
            //Console.WriteLine(diary.Name);
            #endregion

            StreamWriter file = new StreamWriter("C:\\katalog\\plik.txt");
            try
            {
                file.WriteLine("Witaj, piszę do pliku");
            }
            finally
            {
                file.Close();
            }

            using (StreamWriter file2 = new StreamWriter("C:\\katalog\\plik.txt", true))
            {
                file2.WriteLine("Witaj, piszę do pliku w drugiej linijce");
            }

                Console.ReadKey();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmieniono nazwę z {args.ExistingName} na {args.NewName} !");
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("****************");
        }
        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("------------------");
        }

        static void WriteReslt(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result[0] + result[1] + result[2] + result[3]);
        }

        static void WriteReslt(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteReslt(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteReslt(string description, long result, long test)
        {
            Console.WriteLine($"{description}: {result}: i jakiś szajz {2}: {3}: ");
        }
    }
}
