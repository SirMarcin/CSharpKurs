using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "nowy dzienniczek";
        }

        static int IncrementNumber(ref int number)
        {
            number += 10;
            return number;
        }

        static void Main(string[] args)
        {
            //PassByValueAndRef();

            //Immutable();

            Arrays();
        }

        private static void Arrays()
        {
            float[] ratings = new float[4];

            AddRatings(ratings);

            foreach (var rate in ratings)
            {
                Console.WriteLine(rate);
            }
            
        }

        private static void AddRatings(float[] ratings)
        {
            ratings[0] = 0.6f;
            ratings[1] = 2.0f;
            ratings[2] = 5.7f;
            ratings[3] = 2.4f;
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            string newName = name.Trim();
            Console.WriteLine(newName);

            DateTime date = new DateTime(2019, 3, 10);
            date = date.AddHours(48);

            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;


            GiveName(ref d2);
            Console.WriteLine(d2.Name);

            int x1 = 4;

            int x2 = IncrementNumber(ref x1);
            Console.WriteLine(x1);
        }
    }
}
