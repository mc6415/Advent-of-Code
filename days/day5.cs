using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent_of_Code.days
{
    class day5
    {
        public static String[] getInput()
        {
            return File.ReadAllLines("../debug/input/day5.txt");
        }

        public static void howManyNice()
        {
            int count = 0;

            foreach(string input in getInput())
            {
                if(isNice(input))
                {
                    count++;
                }
            }

            Console.WriteLine("There were " + count + " nice strings!");
        }

        /*
         * Rule 1:
         * Contains at least Three vowels
        */
        public static bool rule1(string input)
        {
            Char[] vowels = new Char[5] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            foreach (char character in input)
            {
                if (vowels.Contains(character))
                {
                    count++;
                    if (count >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*
         * Rule 2:
         * Contains at least one letter that appears twice in a row
         */
        public static bool rule2(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                char a = input[i - 1];
                char b = input[i];

                if(input[i-1].Equals(input[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /* 
         * Rule 3:
         * Does not contain 'ab','cd','pq' or 'xy'
         */
        public static bool rule3(string input)
        {
            if(input.IndexOf("ab") > 0 || input.IndexOf("cd") > 0 || input.IndexOf("pq") > 0 || input.IndexOf("xy") > 0)
            {
                return false;
            }

            return true;
        }

        public static bool isNice(string input)
        {
            if (rule1(input) && rule2(input) && rule3(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
