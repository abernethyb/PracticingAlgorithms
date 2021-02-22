using System;
using System.Collections.Generic;
using System.Linq;

namespace seatId
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input { };

            List<string> inputList = input.input.Replace("\r\n", ",").Split(",").ToList();

            foreach (string line in inputList)
            {
                int[] rows = { 0, 127 };
                //int row = -1;
                int columns = 8;
                int colum = -1;
                Console.WriteLine("");
                //char[] lineChar = line.ToCharArray();
                char[] lineChar = { 'F', 'B', 'F', 'B', 'B', 'F', 'F', 'R', 'L', 'R' };

                for (int i = 0; i <= lineChar.Length - 1; i++)
                {
                    //Console.WriteLine(lineChar[i]);

                    if (lineChar[i] == 'F')
                    {
                        rows[1] = (rows[1] + rows[0]) / 2;
                        //rows = rows - row;
                        //Console.WriteLine(row);
                        Console.WriteLine($"{rows[0]}, {rows[1]}");
                    }
                    else if (lineChar[i] == 'B')
                    {
                        rows[0] = (rows[1] + rows[0]) / 2 + 1;
                        //rows = rows - row;
                        //Console.WriteLine(row);
                        Console.WriteLine($"{rows[0]}, {rows[1]}");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}