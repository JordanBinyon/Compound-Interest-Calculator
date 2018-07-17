using System;

namespace Compound_interest_calculator
{
    class Program
    {
        private static double first, last, weekly_deposit;

        private static int year = 1;

        static void Main(string[] args)
        {
            Console.Write("Please enter your starting balance: £");

            first = Double.Parse(Console.ReadLine());

            last = first;

            Console.Write("Please enter your weekly deposit: £");

            weekly_deposit = Double.Parse(Console.ReadLine()) * 52;

            Console.WriteLine("-----------------------------------------------------------------------------".Substring(0, 49));

            for(year = 1; year < 11; year++)
            {
                Console.WriteLine("|" + ("Year: " + year + "                     ").Substring(0, 15) + "|" + ("£" + string.Format("{0:0.00}", ((first + weekly_deposit) * 1.05)) + "                   ").Substring(0, 15) + "|" + ("£" + string.Format("{0:0.00}", (((first + weekly_deposit) * 1.05) - last)) + "                        ").Substring(0, 15) + "|");

                last = first;

                first = (first + weekly_deposit) * 1.05;
            }

            Console.WriteLine("-----------------------------------------------------------------------------".Substring(0, 49));

            Console.ReadLine();
        }
    }
}
