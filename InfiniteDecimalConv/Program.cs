using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfiniteDecimalConv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            string input, intervalStartN, intervalEndN, afterDecimal, interval;
            int intervalStartIndex, timesX, minN, intervalEndIndex, timesY, maxN;

            while (true)
            {
                
                Console.WriteLine("Please enter the infinite decimal:");
                input = Console.ReadLine();

                Console.WriteLine("Enter the start of the infinite segment:");
                intervalStartN = Console.ReadLine();

                Console.WriteLine("Enter the end of the infinite segment: (if there is one repeating num, then write num here)");
                intervalEndN = Console.ReadLine();

                

                if(double.TryParse(input, out n) && n % 1 != 0)
                {                  
                    afterDecimal = input.Substring(input.IndexOf('.') + 1);
                    intervalStartIndex = afterDecimal.IndexOf(intervalStartN[0]);
                    
                    if(intervalStartIndex < 0)
                    {
                        Console.WriteLine("Invalid data provided!");
                        continue;
                    }

                    interval = afterDecimal.Substring(intervalStartIndex);
                    timesX = (int) Math.Pow(10, intervalStartIndex);
                    minN = (int) (n * timesX);       
                    intervalEndIndex = interval.IndexOf(intervalEndN[0]);

                    if (intervalEndIndex < 0)
                    {
                        Console.WriteLine("Invalid data provided!");
                        continue;
                    }

                    timesY = (int) Math.Pow(10, intervalStartIndex + intervalEndIndex + 1);
                    maxN = (int)(n * timesY);

                    //Console.WriteLine("Decimal point index: " + decimalPoint);
                    //Console.WriteLine("AfterDecimal: " + afterDecimal);
                    //Console.WriteLine("TimesY: " + timesY);
                    //Console.WriteLine("Times X: " + timesX);
                    //Console.WriteLine("MaxY: " + (int)maxN);
                    //Console.WriteLine("MinX: " + minN);

                    Console.WriteLine("The division form is: " + (maxN - minN) + "/" + (timesY - timesX));          

                }
                else
                {

                    Console.WriteLine("\nNever gonna give you up, never gonna let you down.\nNever gonna run around and desert you.\nNever gonna make you cry, never gonna say goodbye.");
                }

                Console.ReadKey();
                Console.WriteLine("\n");

            }
            


            
        }
    }
}
