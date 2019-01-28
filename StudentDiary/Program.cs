using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(4.5f);
            //diary.AddRating(3.5f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu od 2 do 5: ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);
              
                if(rating == 11)
                {
                    break;
                }
                if (result == true)
                {
                    if (rating > 2 && rating <= 5)
                    { 
                    diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, zakres od 2 do 5");
                    }
                }
                
            }

            Console.WriteLine("Średnia ocen to : " + diary.CalculateAverage());
            Console.WriteLine("Maksymalna ocena to : " + diary.GiveMaxRating());
            Console.WriteLine("Minimalna ocena to : " + diary.GiveMinRating());

            Console.ReadKey();

            Diary diary2 = new Diary();

        }
    }
}
