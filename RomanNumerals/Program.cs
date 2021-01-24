using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Convert roman numerals to numbers.");
            Console.WriteLine("press q to quit");
            string inputNumeral = "";
            string upperCaseInputNumeral = "";
            while (upperCaseInputNumeral != "Q")
            {
                Console.Write("Enter a valid Roman Numeral: ");
                inputNumeral = Console.ReadLine();
                upperCaseInputNumeral = inputNumeral.ToUpper();

                if (upperCaseInputNumeral != "Q")
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write($"You Entered: {upperCaseInputNumeral} ");
                    Console.WriteLine("");
                    Console.Beep();
                    RomanToInt(upperCaseInputNumeral);
                    Console.WriteLine("");
                    Console.WriteLine("press q to quit");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }

            }

        }
        public static int RomanToInt(string inputString)
        {
            //converting string to array of characters and then to list
            char[] inputarray = inputString.ToArray();
            List<char> numeralList = inputarray.ToList();

            // an empty list to store numbers after they have been converted
            List<int> numbers = new List<int>
            {

            };
            //this will hold the final sum
            int sum = 0;

            // convert numerals to integers
            for (int i = 0; i < numeralList.Count; i++)
            {
                switch (numeralList[i])
                {
                    case 'I':
                        numbers.Add(1);
                        break;
                    case 'V':
                        numbers.Add(5);
                        break;
                    case 'X':
                        numbers.Add(10);
                        break;
                    case 'L':
                        numbers.Add(50);
                        break;
                    case 'C':
                        numbers.Add(100);
                        break;
                    case 'D':
                        numbers.Add(500);
                        break;
                    case 'M':
                        numbers.Add(1000);
                        break;

                }

            }
            // a running sum of numbers added in loop
            int currentSum = 0;
            //remove subtraction instances
            for (int i = 0; i < numbers.Count; i++)
            {

                int firstNum = numbers[i];
                int secondNum = 0;

                try
                {
                    secondNum = numbers[i + 1];

                    switch (secondNum)
                    {
                        case 5:
                            if (firstNum == 1)
                            {
                                currentSum = 4;
                                numbers.RemoveAt(i);
                                numbers.RemoveAt(i);
                                //adjusting increment count after removing numbers
                                i--;
                            }
                            break;
                        case 10:
                            if (firstNum == 1)
                            {
                                currentSum = 9;
                                numbers.RemoveAt(i);
                                numbers.RemoveAt(i);
                                i--;

                            }
                            break;
                        case 50:
                            if (firstNum == 10)
                            {
                                currentSum = 40;
                                numbers.RemoveAt(i);
                                numbers.RemoveAt(i);
                                i--;
                            }
                            break;
                        case 100:
                            if (firstNum == 10)
                            {
                                currentSum = 90;
                                numbers.RemoveAt(i);
                                numbers.RemoveAt(i);
                                i--;
                            }
                            break;
                        case 500:
                            if (firstNum == 100)
                            {
                                currentSum = 400;
                                numbers.RemoveAt(i);
                                numbers.RemoveAt(i);
                                i--;
                            }
                            break;
                        case 1000:
                            if (firstNum == 100)
                            {
                                currentSum = 900;
                                numbers.RemoveAt(i);
                                numbers.RemoveAt(i);
                                i--;
                            }
                            break;

                    }

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    //Console.WriteLine("that was out of range");
                }
                sum += currentSum;
                currentSum = 0;

            }

            //add remaining normal addition cases
            for (int i = 0; i < numbers.Count; i++)
            {

                sum += numbers[i];

            }
            Console.WriteLine($"Returned sum: {sum}");
            return sum;
        }

    }
}