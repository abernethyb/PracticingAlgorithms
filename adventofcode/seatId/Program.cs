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
            List<int> seatIds = new List<int> { };
            foreach (string line in inputList)
            {
                int[] rows = { 0, 127 };
                int[] columns = { 0, 7 };

                char[] lineChar = line.ToCharArray();

                for (int i = 0; i <= lineChar.Length - 1; i++)
                {

                    if (lineChar[i] == 'F')
                    {
                        rows[1] = (rows[1] + rows[0]) / 2;

                    }
                    else if (lineChar[i] == 'B')
                    {
                        rows[0] = (rows[1] + rows[0]) / 2 + 1;

                    }
                    if (lineChar[i] == 'L')
                    {
                        columns[1] = (columns[1] + columns[0]) / 2;

                    }
                    else if (lineChar[i] == 'R')
                    {
                        columns[0] = (columns[1] + columns[0]) / 2 + 1;

                    }
                }
                int row = rows[0];
                int column = columns[0];

                int seatId = row * 8 + column;
                seatIds.Add(seatId);

            }

            int[] idArray = seatIds.ToArray();
            Array.Sort(idArray);
            for (int i = 0; i <= idArray.Length - 1; i++)
            {
                //uncomment to see log of seats:
                //Console.WriteLine($"modified i: {i+ idArray[0]}, seatId {idArray[i]}");
                if (i + idArray[0] != idArray[i])
                {
                    Console.WriteLine(idArray[i] - 1);
                    break;
                }
            }
        }
    }
}