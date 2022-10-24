using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteDecimalConv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the infinite decimal:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the start of the infinite segment:");
            string inputRepeatingN = Console.ReadLine();
            Console.WriteLine("Enter the end of the infinite segment: (if there is one repeating num, then write num here)");
            string inputLastRepeatingN = Console.ReadLine();
            double n, firstNToRepeat, lastNOfInterval;

            try
            {
                n = double.Parse(input);
                firstNToRepeat = int.Parse(inputRepeatingN);
                lastNOfInterval = int.Parse(inputLastRepeatingN);



                int decimalPoint = input.IndexOf(',');
                // Console.WriteLine("Decimal point index: " + decimalPoint);
                string afterDecimal = input.Remove(0, decimalPoint + 1);
                // Console.WriteLine("AfterDecimal: " + afterDecimal);



                int infinityBorder = afterDecimal.IndexOf(inputRepeatingN);
                int timesX = (int)Math.Pow(10, infinityBorder);
                // Console.WriteLine("Times X: " + timesX);
                double minN = n * timesX;
                Console.WriteLine("MinN: " + minN);



                int endOfInterval = afterDecimal.IndexOf(inputLastRepeatingN);
                double timesY = Math.Pow(10, endOfInterval + 1);
                double maxN = n * timesY;
                // Console.WriteLine("TimesY: " + timesY);
                Console.WriteLine("MaxN: " + (int)maxN);


                // Even though maxN is theoretically always int, converting it manages if the user made a misinput
                Console.WriteLine("The division form is: " + ((int)maxN - (int)minN) + "/" + (timesY - timesX));

            }
            catch (System.Exception e)
            {

                Console.WriteLine("Never gonna give you up, never gonna let you down.\nNever gonna run around and desert you.\nNever gonna make you cry, never gonna say goodbye.\n" + e);
            }


            Console.ReadKey();
        }
    }
}
