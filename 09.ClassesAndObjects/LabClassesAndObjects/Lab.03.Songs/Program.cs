using System;
using System.Collections.Generic;

namespace Lab._03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Read the input lines

            List<Song> songs = new List<Song>();   // Make a list of collections 

            for (int i = 0; i < N; i++)
            {
                string[] cmd = Console.ReadLine().Split("_");// Read the input lines

                string type = cmd[0];  // Read the input lines
                string name = cmd[1];  // Read the input lines
                string time = cmd[2];  // Read the input lines

                Song song = new Song();   // Make a collection 

                song.TypeList = type;     
                song.Name = name;
                song.Time = time;

                songs.Add(song);    //store the data
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                    
                }
            }
        }
    }

    // Define a class Song with properties: Type List, Name and Time
    class Song
    {
        public string TypeList { get; set; } // properties
        public string Name { get; set; }
        public string Time { get; set; }
       
    }
 
}
