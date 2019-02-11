using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //InstructionIf();

            //InstructionSwitch();

            //instructionLoops();

            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    foreach (var age in ages)
        //    {
        //        if (age == 2)
        //        {
        //            Console.WriteLine("Wiek wynosi {0}", age);
        //            continue;
        //            Console.WriteLine("hello");
        //        }
        //        if (age == 4)
        //        {
        //            Console.WriteLine("Wiek wynosi {0}", age);
        //            break;
        //            Console.WriteLine("bye");
        //        }
        //    }

        //    foreach (var age in ages)
        //    {
        //        if (age == 2)
        //        {
        //            Console.WriteLine("Wiek wynosi {0}", age);
        //            goto skip;
        //            Console.WriteLine("hello");
        //        }
        //    }

        //skip:
        //    Console.WriteLine("skoczyłem");

            CheckAge(ages);

            Console.ReadKey();
        }

        #region METHODS
        private static void CheckAge(int[] ages)
        {
            foreach (var age in ages)
            {
                if (age == 3)
                {
                    Console.WriteLine("Wiek to {0}", age);
                    return;
                }
            }
        }

        private static void instructionLoops()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.WriteLine("wartość i: {0} a wartość a : {1}", j, a);
                }
            }

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("wartość i: {0}", i);
                i++;
            }

            do
            {
                Console.WriteLine("wychodze z petli..." + i);
                i++;
            } while (i < 4);

            while (i <= 3)
            {
                Console.WriteLine("wchodzę po raz " + i);
                i++;

            }

            int[] tab = { 1, 45, 6, 3, 13, 6 };
            foreach (var number in tab)
            {
                Console.WriteLine($"Twoja liczba to : {number} !");
            }
        }

        private static void InstructionSwitch()
        {
            Console.WriteLine("Podaj imie");
            name = Console.ReadLine();

            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    break;
                default:
                    Method3();
                    break;
            }
        }

        private static void InstructionIf()
        {
            Console.WriteLine("Podaj wiek");
            age = int.Parse(Console.ReadLine());
            string test = age > 18 ? "Pełnoletni" : "dziecko";
            Console.WriteLine(test);

            Console.WriteLine("Podaj wiek");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj imię");
            name = Console.ReadLine();

            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    Method1();
                }

            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
        }


        private static void Method4()
        {
            Console.WriteLine("Masz 30 lub więcej lat");
        }

        private static void Method3()
        {
            Console.WriteLine("Jesteś w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine("jesteś w metodzie 2");
        }

        private static void Method1()
        {
            Console.WriteLine("Jesteś w metodzie 1");
        }
        #endregion METHODS
    }
}
