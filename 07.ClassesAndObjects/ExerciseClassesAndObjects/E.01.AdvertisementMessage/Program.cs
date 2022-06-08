using System;

namespace E._01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] phrases =  new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] autors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            
            for (int i = 0; i < N; i++)
            {
                Random rnd = new Random();
                string phrasesRnd = phrases[rnd.Next(0,6)];
                string eventsRnd = events[rnd.Next(0,6)];
                string autorsRnd = autors[rnd.Next(0,8)];
                string citiesRnd = cities[rnd.Next(0,5)];

                Console.WriteLine($"{phrasesRnd} {eventsRnd} {autorsRnd} - {citiesRnd}");
                
            }
            
        }
    }
}
