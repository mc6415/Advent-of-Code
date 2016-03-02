using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code.days
{
    class day4
    {
        const string input = "iwrupvqb";

        public static void findAnswer()
        {
            int five = 0;
            int six = 0;
            bool fives = false;
            bool sixes = false;

            while (1 < 10)
            {
                if (!fives)
                {
                    if (checkHash(encodeString(input + five.ToString()), 5))
                    {
                        Console.WriteLine("Five leading zeroes is: " + five);
                        fives = true;
                    }
                    else
                    {
                        five++;
                    }
                }

                if (!sixes)
                {
                    if (checkHash(encodeString(input + six.ToString()), 6))
                    {
                        Console.WriteLine("Six Leading zeroes is: " + six);
                        sixes = true;
                    }
                    else
                    {
                        six++;
                    }
                }

                if (fives && sixes)
                {
                    break;
                }
            }
        }

        public static string encodeString(string unencoded)
        {
            byte[] encodedString = new UTF8Encoding().GetBytes(unencoded);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedString);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        public static bool checkHash(string hash, int leadingzero)
        {
            for (int i = 0; i < leadingzero; i++)
            {
                if (hash[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
