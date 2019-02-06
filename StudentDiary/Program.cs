using System;
using System.Speech.Synthesis;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diary diary = new Diary();
            ////diary.AddRating(5);
            ////diary.AddRating(4.5f);
            ////diary.AddRating(3.5f);

            ////float avg = diary.CalculateAverage();
            ////float max = diary.GiveMaxRating();
            ////float min = diary.GiveMinRating();

            //for (; ; )
            //{
            //    Console.WriteLine("Podaj ocenę z zakresu od 2 do 5: ");
            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(), out rating);

            //    if(rating == 11)
            //    {
            //        break;
            //    }
            //    if (result == true)
            //    {
            //        if (rating > 2 && rating <= 5)
            //        { 
            //        diary.AddRating(rating);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Niepoprawna liczba, zakres od 2 do 5");
            //        }
            //    }

            //}

            //Console.WriteLine("Średnia ocen to : " + diary.CalculateAverage());
            //Console.WriteLine("Maksymalna ocena to : " + diary.GiveMaxRating());
            //Console.WriteLine("Minimalna ocena to : " + diary.GiveMinRating());

            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt.Speak("I'm afraid, I can't do it");

            Console.ReadKey();

            //Diary diary2 = new Diary();

        }
    }
}
