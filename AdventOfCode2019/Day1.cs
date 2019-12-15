using System;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace AdventOfCode
{
    class Day1 : IDays
    {
        //Time both parts
        Stopwatch stopwatch = new Stopwatch();

        //When I figure out a better way to do paths, I can fix this.
        static string path = @"C:\Users\Ryzor\source\git\AdventOfCode2019\AdventOfCode2019\inputs\day1.txt";

        //Grab each line of the file and send it to an array
        static string[] inputArray = File.ReadAllLines(path);

        public int Part1()
        {
            stopwatch.Start();

            int totalFuel = 0;
            foreach (string item in inputArray)
            {
                //Convert the line to decimal for math
                decimal input = Decimal.Parse(item);

                //Calculate: fuel req is mass (input) divided by three, rounded down, minus two
                int fuel = Convert.ToInt32(Math.Floor(input / 3) - 2);

                //Sum up all fuel reqs
                totalFuel += fuel;
            }
            stopwatch.Stop();
            WriteLine("Executed in: {0} milliseconds.", stopwatch.Elapsed.TotalMilliseconds);

            return totalFuel;
        }

        public int Part2()
        {
            stopwatch.Restart();

            int totalFuel = 0;
            foreach (string item in inputArray)
            {
                //Convert the line to decimal for math
                decimal remainingMass = Decimal.Parse(item);

                //Continue to calculate new fuel req using mass until none left
                while (remainingMass > 0)
                {
                    //Calculate: fuel req is mass (input) divided by three, rounded down, minus two
                    decimal fuelDec = Math.Floor(remainingMass / 3) - 2;

                    //Handle negative fuel as requiring none
                    if (fuelDec < 0)
                    {
                        fuelDec = 0;
                    }

                    //Convert to int to simplify
                    int fuel = Convert.ToInt32(fuelDec);

                    //Sum up current fuel req
                    totalFuel += fuel;

                    //Treat fuel count as new input mass
                    remainingMass = fuel;
                }
            }

            stopwatch.Stop();
            WriteLine("Executed in: {0} milliseconds.", stopwatch.Elapsed.TotalMilliseconds);
            return totalFuel;
        }
    }
}
