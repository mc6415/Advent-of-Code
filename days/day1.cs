using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent_of_Code.days
{
    class day1
    {
        public static string openFile()
        {
            string output;

            try
            {
                string test = File.ReadAllText("../debug/input/day1.txt");
                output = test;
            }
            catch (FileNotFoundException)
            {
                output = "Couldn't find File!";
            }
            catch (DirectoryNotFoundException)
            {
                output = "Couldn't find Directory!";
                throw;
            }

            return output;
        }

        public static void calculateFloor()
        {
            String puzzle = openFile();
            Char[] test = puzzle.ToCharArray();
            int floor = 0;
            int step = 0;
            int firstBasement = 0;
            foreach (char ins in test)
            {
                char up = '(';
                char down = ')';

                if (ins.Equals(up))
                {
                    floor++;
                    step++;
                    if (floor < 0 && firstBasement == 0)
                    {
                        firstBasement = step;
                    }
                }
                else if (ins.Equals(down))
                {
                    step++;
                    floor--;
                    if (floor < 0 && firstBasement == 0)
                    {
                        firstBasement = step;
                    }
                }
            }

            Console.WriteLine("Finishes on Floor: " + floor);
            Console.WriteLine("Enters the basement on: " + firstBasement);
        }
    }
}
