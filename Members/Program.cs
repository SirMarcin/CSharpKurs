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

            WriteReslt("Średnia", stats.AverageGrade);
            WriteReslt("Najwyższa", stats.MaxGrade);
            WriteReslt("Najniższa", stats.MinGrade);



            Console.ReadKey();
        }

        static void WriteReslt(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteReslt(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteReslt(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
