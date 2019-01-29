using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary;
            diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);
            diary.AddRating(2);
            diary.AddRating(2);

            DiaryStatistics stats = diary.ComputStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.MinGrade);
            Console.WriteLine(stats.MaxGrade);

            Diary diary2;
            diary2 = new Diary();
            diary2.AddRating(3);
            diary2.AddRating(4);
            diary2.AddRating(1);
            diary2.AddRating(1);

            stats = diary2.ComputStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.MinGrade);
            Console.WriteLine(stats.MaxGrade);

        }
    }
}
