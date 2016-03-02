using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent_of_Code.days
{
    class day3
    {
        public static string readInput()
        {
            return File.ReadAllText("../debug/input/day3.txt");
        }

        public static void workOutHouses()
        {
            List<int[]> visited = new List<int[]>();
            int[] coord = new int[2] { 0, 0 };
            visited.Add(new int[] { 0, 0 });

            foreach (char direction in readInput().ToCharArray())
            {
                if (direction.Equals('^'))
                {
                    coord[1]++;
                    if (!checkExists(visited, coord))
                    {
                        visited.Add(new int[] { coord[0], coord[1] });
                    }
                }
                if (direction.Equals('v'))
                {
                    coord[1]--;
                    if (!checkExists(visited, coord))
                    {
                        visited.Add(new int[] { coord[0], coord[1] });
                    }
                }
                if (direction.Equals('<'))
                {
                    coord[0]--;
                    if (!checkExists(visited, coord))
                    {
                        visited.Add(new int[] { coord[0], coord[1] });
                    }
                }
                if (direction.Equals('>'))
                {
                    coord[0]++;
                    if (!checkExists(visited, coord))
                    {
                        visited.Add(new int[] { coord[0], coord[1] });
                    }
                }
            }
            Console.WriteLine("Different Houses visited: " + visited.Count);
        }

        public static void housesRobo()
        {
            List<int[]> visited = new List<int[]>();
            int[] santaCoord = new int[2] { 0, 0 };
            int[] roboCoord = new int[2] { 0, 0 };
            visited.Add(new int[] { 0, 0 });
            int turn = 0;

            foreach (var direction in readInput().ToCharArray().Select((value, index) => new {value, index}))
            {
                // direction.index % 2 alternates between 0 & 1
                if (direction.value.Equals('^'))
                {
                    if((direction.index % 2) == 0)
                    {
                        santaCoord[1]++;
                        if (!checkExists(visited, santaCoord))
                        {
                            visited.Add(new int[] { santaCoord[0], santaCoord[1] });
                        }
                    }
                    else
                    {
                        roboCoord[1]++;
                        if(!checkExists(visited, roboCoord))
                        {
                            visited.Add(new int[] { roboCoord[0], roboCoord[1] });
                        }
                    }                    
                }
                if (direction.value.Equals('v'))
                {
                    if((direction.index % 2) == 0)
                    {
                        santaCoord[1]--;
                        if (!checkExists(visited, santaCoord))
                        {
                            visited.Add(new int[] { santaCoord[0], santaCoord[1] });
                        }
                    }
                    else
                    {
                        roboCoord[1]--;
                        if(!checkExists(visited, roboCoord))
                        {
                            visited.Add(new int[]{roboCoord[0], roboCoord[1]});
                        }
                    }               
                }
                if (direction.value.Equals('<'))
                {
                    if((direction.index % 2) == 0)
                    {
                        santaCoord[0]--;
                        if (!checkExists(visited, santaCoord))
                        {
                            visited.Add(new int[] { santaCoord[0], santaCoord[1] });
                        }
                    }
                    else
                    {
                        roboCoord[0]--;
                        if(!checkExists(visited, roboCoord))
                        {
                            visited.Add(new int[]{roboCoord[0], roboCoord[1]});
                        }
                    }         
                }
                if (direction.value.Equals('>'))
                {
                     if((direction.index % 2) == 0)
                    {
                        santaCoord[0]++;
                        if (!checkExists(visited, santaCoord))
                        {
                            visited.Add(new int[] { santaCoord[0], santaCoord[1] });
                        }
                    }
                    else
                    {
                        roboCoord[0]++;
                        if(!checkExists(visited, roboCoord))
                        {
                            visited.Add(new int[]{roboCoord[0], roboCoord[1]});
                        }
                    }         
                }
            }

            Console.WriteLine("With the help of the robot houses visited: " + visited.Count);
        }

        public static bool checkExists(List<int[]> map, int[] coord)
        {
            foreach (int[] point in map)
            {
                if (coord.SequenceEqual(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
