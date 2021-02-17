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

            int linePosition = 0;
            //int listPosition = 0;
            int treeCollisons = 0;

            foreach (string line in inputList)
            {

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

                if (linePosition == line.Count() - 1)
                {
                    linePosition = 2;

                }
                else if (linePosition == line.Count() - 2)
                {
                    linePosition = 1;

                }
                else if (linePosition == line.Count() - 3)
                {
                    linePosition = 0;

                }
                else
                {
                    linePosition += 3;
                }

                // listPosition++;
                // Console.WriteLine(linePosition);
                // Console.WriteLine(listPosition);
            }
            Console.WriteLine($"Total number of collisions with trees: {treeCollisons}");

        }
    }
}