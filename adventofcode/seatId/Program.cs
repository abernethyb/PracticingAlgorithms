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

                Console.WriteLine("");
                char[] lineChar = line.ToCharArray();
                //char[] lineChar = { 'F', 'B', 'F', 'B', 'B', 'F', 'F', 'R', 'L', 'R' };
                //char[] lineChar = { 'B', 'F', 'F', 'F', 'B', 'B', 'F', 'R', 'R', 'R' };

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
                    if (lineChar[i] == 'L')
                    {
                        columns[1] = (columns[1] + columns[0]) / 2;
                        //rows = rows - row;
                        //Console.WriteLine(row);
                        Console.WriteLine($"{columns[0]}, {columns[1]}");
                    }
                    else if (lineChar[i] == 'R')
                    {
                        columns[0] = (columns[1] + columns[0]) / 2 + 1;
                        //rows = rows - row;
                        //Console.WriteLine(row);
                        Console.WriteLine($"{columns[0]}, {columns[1]}");
                    }
                }
                int row = rows[0];
                int column = columns[0];

                int seatId = row * 8 + column;
                seatIds.Add(seatId);

                Console.WriteLine("");
                Console.Write($"row: {row}, column: {column}. SeatID: {seatId}");
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(seatIds.Max());
        }
    }
}