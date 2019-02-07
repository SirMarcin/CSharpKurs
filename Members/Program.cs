using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3f);
            diary.AddRating(3.5f);
            diary.AddRating(4f);
            diary.AddRating(5f);

            DiaryStatistics stats = diary.ComputStatistics();

            
            WriteReslt("Najniższa", (long)stats.MinGrade, 2);
            WriteReslt("Najwyższa", (int)stats.MaxGrade);
            WriteReslt("Średnia", stats.AverageGrade, 2, 5 ,6 ,7);
            WriteReslt("Najniższa", (long)stats.MinGrade);
            



            Console.ReadKey();
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
