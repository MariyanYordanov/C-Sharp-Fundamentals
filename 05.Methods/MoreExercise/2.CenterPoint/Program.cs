using System;

namespace _2.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lengthFirstLine = LengthLine(x1, y1, x2, y2);
            double lengthSecondLine = LengthLine(x3, y3, x4, y4);

            if (lengthFirstLine > lengthSecondLine)
            {
                CloserToCenterPoint(x1, y1, x2, y2);
            }
            else if (lengthFirstLine < lengthSecondLine)
            {
                CloserToCenterPoint(x3, y3, x4, y4);
            }
            else
            {
                CloserToCenterPoint(x1, y1, x2, y2);
            }
            
        }

        private static double LengthLine(double x1, double y1, double x2, double y2)
        {
            double x = x1 - x2;
            double y = y1 - y2;
            double lengthLine = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
            return lengthLine;
        }

        private static void CloserToCenterPoint(double x1, double y1, double x2, double y2)
        {
            if ((Math.Sqrt((x1 * x1) + (y1 * y1))) > Math.Sqrt(((x2 * x2) + (y2 * y2))))
            {
                Console.Write($"({x2}, {y2})({x1}, {y1})");
            }
            else if ((Math.Sqrt((x1 * x1) + (y1 * y1))) < Math.Sqrt(((x2 * x2) + (y2 * y2))))
            {
                Console.Write($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x1}, {y1})({x2}, {y2})");
            }
        }
    }
}
