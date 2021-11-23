using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts so Interesting You'll Say, OMG! ");
            string filePath = @"C:\Users\opilane\Samples\funfacts.txt";
            string[] FunFacts = File.ReadAllLines(filePath);

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, FunFacts.Length);
            Console.WriteLine(FunFacts[randomIndex]);

            Console.WriteLine(GetRandomFact());
        }

        public static string GetRandomFact()
        {
            string filePath = @":\Users\opilane\Samples\funfacts.txt";
            string[] FunFacts = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, FunFacts.Length);

            return FunFacts[randomIndex];
        }
    }
}
