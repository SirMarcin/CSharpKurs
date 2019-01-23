using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            //Console.WriteLine("Hello! " + name);

            foreach (var item in args)
            {
                Console.WriteLine("Witaj, " + item );
            }
        
        }
    }
}
