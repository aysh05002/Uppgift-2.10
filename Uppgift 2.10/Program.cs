using System;

namespace Uppgift_2_1
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hej \nJag undrar om vad dit favoritbok heter ?");
            string bok = Console.ReadLine();
            Console.WriteLine("Vad fint att dit favorit bok är " + bok);
        }
    }
}