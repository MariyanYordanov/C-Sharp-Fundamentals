using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME._05.DragonArmy
{
    public class DragonStat
    {
        public DragonStat()
        {
            Health = 250;
            Damage = 45;
            Armor = 10;
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
    }
}
