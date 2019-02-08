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
            Console.WriteLine("Podaj wiek");
            age = int.Parse(Console.ReadLine());
            string test = age > 18 ? "Pełnoletni" : "dziecko";
            Console.WriteLine(test);

            //Console.WriteLine("Podaj wiek");
            //age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj imię");
            //name = Console.ReadLine();

            //if (age <= 10)
            //{
            //    if (name == "Marcin")
            //    {
            //        Method1();
            //    }
                
            //}
            //else if (age < 20)
            //{
            //    Method2(age);
            //}
            //else if (age < 30)
            //{
            //    Method3(age);
            //}
            //else
            //{
            //    Method4();
            //}

            Console.ReadKey();
        }

        private static void Method4()
        {
            Console.WriteLine("Masz 30 lub więcej lat");
        }

        private static void Method3(int age)
        {
            Console.WriteLine($"Masz więcej niż 20 lat ale mniej niż 30, dokładnie masz {age}");
        }

        private static void Method2(int age)
        {
            Console.WriteLine($"Masz więcej niż 10 lat ale mniej niż 20, dokładnie masz {age}");
        }

        private static void Method1()
        {
            Console.WriteLine("Masz 10 lub mniej lat");
        }
    }
}
