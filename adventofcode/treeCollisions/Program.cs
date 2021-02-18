using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace treeCollisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            string commaInput = input.input.Replace("\r\n", ",");
            List<string> inputList = commaInput.Split(",").ToList();
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Welcome to the sledding hill!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("There are many trees");
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("Below is the slope.  each '.' represents a clear path, while each '#' represents a tree.");
            Console.WriteLine("");
            Console.Write("hit enter to continue");
            Console.ReadLine();
            Console.Beep();
            Console.WriteLine("");

            Console.WriteLine(input.input);

            CalculateRouteManuallt(inputList);

            Console.WriteLine("");
            Console.WriteLine("Thanks for Playing!");
            Console.Write("press enter to see the best slope: ");
            Console.ReadLine();

            ComputerCalculate(inputList);

        }
        static void CalculateRouteManuallt(List<string> inputList)
        {
            List<SlopeRecord> userSlopeRecords = new List<SlopeRecord> { };
            Console.WriteLine("");
            Console.WriteLine("The pattern above repeates to the right indefinitely");
            Console.WriteLine("");
            Console.WriteLine("Try to hit as few trees as possible.");
            Console.WriteLine("");
            Console.WriteLine("enter some slopes:");
            Console.WriteLine("");

            string stringRunInput = "";
            string stringRiseInput = "";

            while (stringRunInput != "q" && stringRunInput != "Q")
            {

                int linePosition = 0;
                int collisons = 0;

                Console.Write("Enter 'q' to exit or enter slope run: ");

                stringRunInput = Console.ReadLine();
                if (stringRunInput != "q" && stringRunInput != "Q")
                {

                    Console.Write("Enter slope rise: ");

                    stringRiseInput = Console.ReadLine();

                    int runInput = 1;
                    int riseInput = 1;

                    try
                    {
                        runInput = Int32.Parse(stringRunInput);

                        riseInput = Int32.Parse(stringRiseInput);
                    }
                    catch (System.FormatException)
                    {

                    }

                    Console.WriteLine($"right {runInput}, down: {riseInput}");

                    for (int i = 0; i <= inputList.Count() - 1; i += riseInput)
                    {
                        char[] line = inputList[i].ToCharArray();
                        if (line[linePosition] == '#')
                        {
                            //uncomment below for fun version
                            //Console.WriteLine("OUCH!!");
                            collisons++;
                        }
                        ////uncomment below for fun version
                        // else
                        // {

                        //     Console.WriteLine("PHEW!");
                        // }

                        if (linePosition + runInput >= line.Count())
                        {
                            linePosition = linePosition - line.Count();

                        }

                        linePosition += runInput;

                    }
                    Console.WriteLine($"Total number of collisions with trees: {collisons}");

                    SlopeRecord userSlopeRecord = new SlopeRecord { };
                    userSlopeRecord.run = runInput;
                    userSlopeRecord.rise = riseInput;
                    userSlopeRecord.totalCollisions = collisons;

                    userSlopeRecords.Add(userSlopeRecord);

                    Thread.Sleep(4000);
                    Console.Beep(200, 200);
                    Console.Clear();
                }
            }
            int winner = userSlopeRecords.Min(rec => rec.totalCollisions);
            //int loser = userSlopeRecords.Max(rec => rec.totalCollisions);
            foreach (SlopeRecord record in userSlopeRecords)
            {
                if (record.totalCollisions == winner)
                {

                    Console.WriteLine($"your best run: {winner} collisions.");
                    Console.WriteLine($"{record.run} right");
                    Console.WriteLine($"{record.rise} down");
                    Console.WriteLine($"{record.totalCollisions} collisions");
                }
            }
        }
        static void ComputerCalculate(List<string> inputList)
        {

            List<SlopeRecord> slopeRecords = new List<SlopeRecord> { };

            for (int i = 0; i < 10; i++)
            {

                for (int j = 1; j < 10; j++)
                {
                    int linePosition = 0;
                    int collisons = 0;

                    int runInput = i;
                    int riseInput = j;

                    for (int k = 0; k <= inputList.Count() - 1; k += riseInput)
                    {
                        char[] line = inputList[k].ToCharArray();
                        if (line[linePosition] == '#')
                        {
                            //uncomment below for fun version
                            //Console.WriteLine("OUCH!!");
                            collisons++;
                        }
                        ////uncomment below for fun version
                        // else
                        // {

                        //     Console.WriteLine("PHEW!");
                        // }

                        if (linePosition + runInput >= line.Count())
                        {
                            linePosition = linePosition - line.Count();

                        }

                        linePosition += runInput;

                    }

                    SlopeRecord slopeRecord = new SlopeRecord { };
                    slopeRecord.run = runInput;
                    slopeRecord.rise = riseInput;
                    slopeRecord.totalCollisions = collisons;

                    slopeRecords.Add(slopeRecord);
                }
            }

            int winner = slopeRecords.Min(rec => rec.totalCollisions);
            //int loser = slopeRecords.Max(rec => rec.totalCollisions);
            foreach (SlopeRecord record in slopeRecords)
            {
                if (record.totalCollisions == winner)
                {

                    Console.WriteLine($"winner is {winner}");
                    Console.WriteLine($"{record.run} right");
                    Console.WriteLine($"{record.rise} down");
                    Console.WriteLine($"{record.totalCollisions} collisions");
                }
            }

        }
    }
}