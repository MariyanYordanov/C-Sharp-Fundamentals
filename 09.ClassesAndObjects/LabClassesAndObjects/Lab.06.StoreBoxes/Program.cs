using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab._06.StoreBoxes
{
    class Program
    {
        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Box
        {
            
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal BoxPrice { get; set; }

            public void PrintBoxes()
            {
                Console.WriteLine($"{SerialNumber}\n-- {Item.Name} - ${Item.Price:f2}: {ItemQuantity}\n-- ${BoxPrice:f2}");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (input != "end")
            {
                string[] cmd = input.Split();

                string serialNumber = cmd[0];
                string itemName = cmd[1];
                int itemQuantity = int.Parse(cmd[2]);
                decimal itemPrice = decimal.Parse(cmd[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuantity,
                    BoxPrice = itemPrice * itemQuantity,
                    Item = new Item()
                    {
                        Name = itemName,
                        Price = itemPrice
                    }
                };
               
                
                boxes.Add(box);
                input = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                box.PrintBoxes();
            }
        }
    }
}
