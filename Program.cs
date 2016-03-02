using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent_of_Code.days;

namespace Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dayHeader(1));
            day1.calculateFloor();

            Console.WriteLine(dayHeader(2));
            day2.calculateWrappingPaper();
            day2.calculateRibbon();

            Console.WriteLine(dayHeader(3));
            day3.workOutHouses();
            day3.housesRobo();

            Console.WriteLine(dayHeader(4));
            day4.findAnswer();

            Console.ReadKey();
        }

        static string dayHeader(int day)
        {
            return "--------------- DAY " + day + " --------------------";
        }
    }
}
