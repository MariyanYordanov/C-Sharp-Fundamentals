using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace E._4._2.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternBarcode = @"\@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])\@#+";
            string patternProducts = @"\d";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match matchBarcode = Regex.Match(input,patternBarcode);
                string productGroup = "";
                if (matchBarcode.Success)
                {
                    string product = matchBarcode.Value;
                    MatchCollection matchProducts = Regex.Matches(product, patternProducts);
                    matchProducts.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
                    if (matchProducts.Count > 0)
                    {
                        foreach (Match matches in matchProducts)
                        {
                            productGroup += matches;
                        }
                        
                    }
                    else
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    productGroup = "00";
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
