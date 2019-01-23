using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Greeting();
                Age();
                Settings();

            }

        }
        /// <summary>
        /// Resetujemy ustawienia konsoli
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Pytamy użytkownika o jego wiek
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś pełnoletni, możesz wypić browara :)");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawnie wiek !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Napij się mleka dzieciaku! xD");

            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wprowadź swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Cześć! " + name);
        }
    }
}
//33:00/42:37 Odcinek 6)