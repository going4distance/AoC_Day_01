using System;
using System.Collections.Generic;

namespace AdventOfCode_Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Advent of Code - Day 1       https://adventofcode.com/2018/day/1     */
            string TextFilePath = @"C:\Users\computer\source\repos\Advent_Calendar_-_day_1_input.txt";

            findFreqPart1(TextFilePath);
            //  ============== END PART 1 ============== 

            findRepeatingFreqPart2(TextFilePath);
            //  ============== END PART 2 ============== 

            Console.WriteLine("\nThe End!");
            Console.ReadLine();
        }

        static void findRepeatingFreqPart2(string textPath)
        {// This function satisfies part 2 of the Day 1 problem.
            string s; int frequency = 0;  bool foundRepeat = false;
            List<int> recordedFreq = new List<int>();
            string[] myFullFile = System.IO.File.ReadAllLines(textPath);

            recordedFreq.Add(frequency);
            while (!foundRepeat)
            {
                for (int x = 0; x < myFullFile.Length; x++)
                {
                    frequency += Convert.ToInt32(myFullFile[x]);
                    if (!recordedFreq.Contains(frequency))
                    {
                        recordedFreq.Add(frequency);
                    }
                    else
                    {
                        foundRepeat = true;
                        break;
                    }
                }
            }
            Console.WriteLine("The first repeating frequency is {0}.", frequency);
        }

        static void findFreqPart1(string textPath)
        {   // This function satisfies part 1 of the Day 1 problem.
            string s; int frequency = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(textPath);
            while ((s = file.ReadLine()) != null)
            {
                frequency += Convert.ToInt32(s);
            }
            file.Close();
            Console.WriteLine("The final frequency is {0}.", frequency);
        }
    }
}
