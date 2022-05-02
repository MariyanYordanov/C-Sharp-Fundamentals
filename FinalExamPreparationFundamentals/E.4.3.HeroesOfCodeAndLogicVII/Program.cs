using System;
using System.Collections.Generic;
using System.Linq;

namespace E._4._3.HeroesOfCodeAndLogicVII
{
    class Program
    {
        class Heros
        {
            public int HitPoints { get; set; }
            public int ManaPoints { get; set; }
        }
        static void Main(string[] args)
        {
            int heros = int.Parse(Console.ReadLine());
            Dictionary<string, Heros> dictionary = new Dictionary<string, Heros>();
            for (int i = 0; i < heros; i++)
            {
                string[] points = Console.ReadLine().Split();
                string name = points[0];
                int hit = int.Parse(points[1]);
                int mana  = int.Parse(points[2]);
                dictionary.Add(name, new Heros()
                {
                    HitPoints = hit,
                    ManaPoints = mana
                });
            }

            string commands = Console.ReadLine();
            while (commands != "End")
            {
                string[] cmd = commands.Split(" - ");
                string leedCommand = cmd[0];
                if (leedCommand == "CastSpell")
                {
                    string name = cmd[1];
                    int mp = int.Parse(cmd[2]);
                    string spell = cmd[3];
                    if (dictionary.ContainsKey(name))
                    {
                        if (dictionary[name].ManaPoints >= mp)
                        {
                            dictionary[name].ManaPoints -= mp;
                            Console.WriteLine($"{name} has successfully cast {spell} and now has {dictionary[name].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                        }
                    }
                }
                else if (leedCommand == "TakeDamage")
                {
                    string name = cmd[1];
                    int damage = int.Parse(cmd[2]);
                    string attacker = cmd[3];
                    if (dictionary.ContainsKey(name))
                    {
                        dictionary[name].HitPoints -= damage;
                        if (dictionary[name].HitPoints > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {dictionary[name].HitPoints} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                            dictionary.Remove(name);
                        }

                    }

                }
                else if (leedCommand == "Recharge")
                {
                    string name = cmd[1];
                    int amount = int.Parse(cmd[2]);
                    int prevManaPoints = dictionary[name].ManaPoints;
                    if (dictionary.ContainsKey(name))
                    {
                        dictionary[name].ManaPoints += amount;
                        if (dictionary[name].ManaPoints > 200)
                        {
                            dictionary[name].ManaPoints = 200;
                        }

                        Console.WriteLine($"{name} recharged for {dictionary[name].ManaPoints - prevManaPoints} MP!");
                    }

                }
                else if (leedCommand == "Heal")
                {
                    string name = cmd[1];
                    int amount = int.Parse(cmd[2]);
                    int prevHitsPoints = dictionary[name].HitPoints;
                    if (dictionary.ContainsKey(name))
                    {
                        dictionary[name].HitPoints += amount;
                        if (dictionary[name].HitPoints > 100)
                        {
                            dictionary[name].HitPoints = 100;
                        }
                       
                        Console.WriteLine($"{name} healed for {dictionary[name].HitPoints - prevHitsPoints} HP!");
                    }

                }

                commands = Console.ReadLine();
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value.HitPoints).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}\n HP: {item.Value.HitPoints}\n MP: {item.Value.ManaPoints}");
            }
        }
    }
}
