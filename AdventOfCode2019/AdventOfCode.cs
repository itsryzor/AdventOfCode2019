using System;
using static System.Console;

namespace AdventOfCode
{
    class AdventOfCode
    {
        static void Main()
        {
            Days days = new Days();

            days.Welcome();
            days.DayChoice();
        }

        class Days
        {
            public void Welcome() //display the names and numbers for each exercise
            {
                WriteLine("Welcome to Advent of Code 2019!");
                WriteLine("All available days are listed below.");
                WriteLine("Please select from one of the following options or press 0 to exit:");
                WriteLine();
                WriteLine("1. The Tyranny of the Rocket Equation");
                WriteLine("2. 1202 Program Alarm");
                WriteLine();
            }

            public void DayChoice()
            {
                bool exit = false;
                do
                {
                    int dayChoice = 0;
                    try
                    {
                        dayChoice = Convert.ToInt32(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine("Error: " + e.Message);
                        WriteLine("Please try again.");
                        dayChoice = Convert.ToInt32(ReadLine());
                    }
                    
                    switch (dayChoice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            WriteLine("--- Day 1: The Tyranny of the Rocket Equation ---");
                            Day1 day1 = new Day1();

                            //Run part 1
                            WriteLine("Part 1 will now execute.");
                            int output = day1.Part1();
                            WriteLine("Total fuel required for part 1: {0}", output);
                            //Run part 2
                            WriteLine("Part 2 will now execute.");
                            int output2 = day1.Part2();
                            WriteLine("Total fuel required for part 2: {0}", output2);
                            break;
                        case 2:
                            WriteLine("--- Day 2: 1202 Program Alarm ---");
                            Day2 day2 = new Day2();

                            //Run part 1
                            WriteLine("Part 1 will now execute.");
                            output = day2.Part1();
                            //Run part 2
                            WriteLine("Part 2 will now execute.");
                            output2 = day2.Part2();
                            break;
                        default:
                            WriteLine("Invalid option selected. Please select a valid option or press 0 to exit.");
                            break;
                    }
                    if (dayChoice != 0)
                    {
                        WriteLine("Select another exercise or press 0 to exit.");
                    }
                    else
                    {
                        WriteLine("The program will now exit.");
                    }
                }
                while (!exit);
            }
        }
    }

    public interface IDays
    {
        int Part1();

        int Part2();
    }
}
