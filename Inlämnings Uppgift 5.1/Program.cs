using System;
namespace uupgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 namn på en rad");
            string[] namn = Console.ReadLine().Split();
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]); 
            }
            Console.ReadKey():
        }
    }
}
