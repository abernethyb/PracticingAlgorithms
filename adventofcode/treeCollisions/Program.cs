using System;
using System.Collections.Generic;
using System.Linq;

namespace treeCollisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            string commaInput = input.input.Replace("\r\n", ",");
            List<string> inputList = commaInput.Split(",").ToList();

            string stringRunInput = "";
            string stringRiseInput = "";
            while (stringRunInput != "q" || stringRunInput != "Q")
            {
                int linePosition = 0;
                int treeCollisons = 0;

                Console.Write("Enter slope run or q to exit: ");

                stringRunInput = Console.ReadLine();

                Console.Write("Enter slope rise q to exit: ");

                stringRiseInput = Console.ReadLine();

                int runInput = Int32.Parse(stringRunInput);

                int riseInput = Int32.Parse(stringRiseInput);

                Console.WriteLine($"right {runInput}, down: {riseInput}");

                for (int i = 0; i <= inputList.Count() - 1; i += riseInput)
                {
                    char[] line = inputList[i].ToCharArray();
                    if (line[linePosition] == '#')
                    {
                        //uncomment below for fun version
                        //Console.WriteLine("OUCH!!");
                        treeCollisons++;
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
                Console.WriteLine($"Total number of collisions with trees: {treeCollisons}");
            }

        }
    }
}