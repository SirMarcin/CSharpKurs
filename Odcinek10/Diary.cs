using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    public class Diary
    {

        public Diary()
        {
            ratings = new List<float>();
            Count++;
        }

        //Stan (zmienne - pola)
        private List<float> ratings;

        public static float MinGrade = 2;
        public static float MaxGrade = 5;
        public static long Count = 0;
        public string Name;

        //Zachowania
        /// <summary>
        /// Podaje statystki dotyczące ocen takie jak średnia, najwyższa ocena i najniższa ocena
        /// </summary>
        /// <returns></returns>
        public DiaryStatistics ComputStatistics()
        {

            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();
            
            return stats;
        }


        /// <summary>
        /// Dodawanie nowej oceny
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {

                if (rating >=2 && rating <= 5)
                {
                    ratings.Add(rating);
                }

        }

    }
}
