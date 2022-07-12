using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AdventOfCode
{
    class Day2 : IDays
    {
        //Time both parts
        Stopwatch stopwatch = new Stopwatch();

        //When I figure out a better way to do paths, I can fix this.
        static string path = @"C:\Users\Ryzor\source\git\AdventOfCode2019\AdventOfCode2019\inputs\day2.txt";

        static string input = File.ReadAllText(path);

        //Grab each line of the file and send it to an array
        static string[] inputArray = input.Split(',');
        //Convert the array to int for easier processing
        int[] intInputArray = Array.ConvertAll(inputArray, new Converter<string, int>(StringToInt));

        public int Part1()
        {
            
            return 0;
        }

        public int Part2()
        {
            foreach (int item in intInputArray)
            {
                Console.WriteLine(item);
            }
            return 0;
        }

        static int StringToInt(string s)
        {
            return Int32.Parse(s);
        }
    }
}
