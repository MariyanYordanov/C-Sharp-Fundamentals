using System;
using System.Collections.Generic;
using System.Linq;

namespace E._1._3._03.ThePianist
{
    class Program
    {
        class Pieces
        {
            public string Composer { get; set; }
            public string Key { get; set; }
        }
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, Pieces> dataForPieces = new Dictionary<string, Pieces>();
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieces = Console.ReadLine().Split("|");
                string name = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];
                dataForPieces.Add(name, new Pieces()
                {
                    Composer = composer,
                    Key = key
                });
            }

            string commands = Console.ReadLine();
            while (commands != "Stop")
            {
                string[] cmd = commands.Split("|");
                string leedCmd = cmd[0];
                if (leedCmd == "Add")
                {
                    string piece = cmd[1];
                    string composer = cmd[2];
                    string key = cmd[3];
                    if (!dataForPieces.ContainsKey(piece))
                    {
                        dataForPieces.Add(piece, new Pieces()
                        {
                            Composer = composer,
                            Key = key
                        });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (leedCmd == "Remove")
                {
                    string piece = cmd[1];
                    if (dataForPieces.ContainsKey(piece))
                    {
                        dataForPieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (leedCmd == "ChangeKey")
                {
                    string piece = cmd[1];
                    string newKey = cmd[2];
                    if (dataForPieces.ContainsKey(piece))
                    {
                        dataForPieces[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                commands = Console.ReadLine();
            }

            foreach (var item in dataForPieces.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }
        }
    }
}
