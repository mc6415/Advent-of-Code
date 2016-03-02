using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent_of_Code.days
{
    class day2
    {
        public static string[] getInput()
        {
            return File.ReadAllLines("../debug/input/day2.txt");
        }

        public static void calculateWrappingPaper()
        {
            int totalPaper = 0;

            foreach (string pres in getInput())
            {
                int[] dimensions = Array.ConvertAll<string, int>(pres.Split('x'), int.Parse);
                int[] mults = new int[3]{(dimensions[0]*dimensions[1]),(dimensions[1]*dimensions[2]),(dimensions[0]*dimensions[2])};
                int slack = mults.Min();
                int paper = ((2 * (dimensions[0] * dimensions[1])) + (2 * (dimensions[1] * dimensions[2])) + (2 * (dimensions[0] * dimensions[2])));
                totalPaper += (paper + slack);
            }

            Console.WriteLine("Total Paper needed: " + totalPaper);
        }

        public static void calculateRibbon()
        {
            int totalRibbon = 0;

            foreach(string pres in getInput())
            {
                int[] dimensions = Array.ConvertAll<string, int>(pres.Split('x'), int.Parse);
                int[] perims = new int[3]{((2*dimensions[0])+(2*dimensions[1])),((2*dimensions[1]) + (2*dimensions[2])),((2*dimensions[0])+(2*dimensions[2]))};
                int bow = perims.Min();
                int wrap = (dimensions[0] * dimensions[1] * dimensions[2]);

                totalRibbon += (bow + wrap);
            }

            Console.WriteLine("Total Ribbon needed: " + totalRibbon);
        }
    }
}
