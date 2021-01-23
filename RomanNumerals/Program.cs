using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class Program
    {
        //in progress...
        static void Main(string[] args)
        {
            Console.WriteLine("Convert roman numerals to numbers.");
            RomanToInt("MMXIX");

        }
        static void RomanToInt(string inputString)
        {
            char[] inputarray = inputString.ToArray();
            List<char> numeralList = inputarray.ToList();
            List<int> numbers = new List<int>
            {

            };
            int sum = 0;

            for (int i = 0; i < numeralList.Count; i++)
            {
                switch (numeralList[i])
                {
                    case 'I':
                        numbers.Add(1);
                        Console.WriteLine("1");
                        break;
                    case 'V':
                        numbers.Add(5);
                        Console.WriteLine("5");
                        break;
                    case 'X':
                        numbers.Add(10);
                        Console.WriteLine("10");
                        break;
                    case 'L':
                        numbers.Add(50);
                        Console.WriteLine("50");
                        break;
                    case 'C':
                        numbers.Add(100);
                        Console.WriteLine("100");
                        break;
                    case 'D':
                        numbers.Add(500);
                        Console.WriteLine("500");
                        break;
                    case 'M':
                        numbers.Add(1000);
                        Console.WriteLine("1000");
                        break;

                }

            }
            // a running sum of numbers added in for loops
            int currentSum = 0;
            //remove subtraction instances
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.WriteLine($"first loop: corrent numbers: {numbers[j]}");
                };
                int firstNum = numbers[i];
                int secondNum = 0;

                try
                {
                    Console.WriteLine($"i: {numbers[i]}");
                    secondNum = numbers[i + 1];
                    Console.WriteLine($"firstNum: {firstNum}");
                    Console.WriteLine($"secondNum: {secondNum}");

                    switch (secondNum)
                    {
                        case 5:
                            if (firstNum == 1)
                            {
                                currentSum = 4;
                                Console.WriteLine($"i value: {numbers[i]}");
                                Console.WriteLine($"i actual: {i}");
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                i--;
                            }
                            // else
                            // {
                            //     currentSum = firstNum + secondNum;
                            // }
                            break;
                        case 10:
                            if (firstNum == 1)
                            {
                                currentSum = 9;
                                Console.WriteLine($"i value: {numbers[i]}");
                                Console.WriteLine($"i actual: {i}");
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                i--;

                            }
                            // else
                            // {
                            //     currentSum = firstNum + secondNum;
                            // }
                            break;
                        case 50:
                            if (firstNum == 10)
                            {
                                currentSum = 40;
                                Console.WriteLine($"i value: {numbers[i]}");
                                Console.WriteLine($"i actual: {i}");
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                i--;
                            }
                            // else
                            // {
                            //     currentSum = firstNum + secondNum;
                            // }
                            break;
                        case 100:
                            if (firstNum == 10)
                            {
                                currentSum = 90;
                                Console.WriteLine($"i value: {numbers[i]}");
                                Console.WriteLine($"i actual: {i}");
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                i--;
                            }
                            // else
                            // {
                            //     currentSum = firstNum + secondNum;
                            // }
                            break;
                        case 500:
                            if (firstNum == 100)
                            {
                                currentSum = 400;
                                Console.WriteLine($"i value: {numbers[i]}");
                                Console.WriteLine($"i actual: {i}");
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                i--;
                            }
                            // else
                            // {
                            //     currentSum = firstNum + secondNum;
                            // }
                            break;
                        case 1000:
                            if (firstNum == 100)
                            {
                                currentSum = 900;
                                Console.WriteLine($"i value: {numbers[i]}");
                                Console.WriteLine($"i actual: {i}");
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                Console.WriteLine($"Removing {numbers[i]}");
                                numbers.RemoveAt(i);
                                i--;
                            }
                            // else
                            // {
                            //     currentSum = firstNum + secondNum;
                            // }
                            break;
                            // default:
                            //     currentSum = firstNum + secondNum;
                            //     break;

                    }

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("that was out of range");
                    //currentSum = firstNum;
                }
                sum += currentSum;

                Console.WriteLine($"sum: {sum}");
            }

            //add remaining normal addition cases
            for (int i = 0; i < numbers.Count; i += 2)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.WriteLine($"second loop: corrent numbers: {numbers[j]}");
                };
                int firstNum = numbers[i];
                int secondNum = 0;

                try
                {
                    Console.WriteLine($"i: {numbers[i]}");
                    Console.WriteLine($"i + 1: {numbers[i]}");
                    secondNum = numbers[i + 1];
                    Console.WriteLine($"firstNum: {firstNum}");
                    Console.WriteLine($"secondNum: {secondNum}");
                    currentSum = firstNum + secondNum;
                    // switch (secondNum)
                    // {
                    //     case 5:
                    //         if (firstNum == 1)
                    //         {
                    //             currentSum = 4;
                    //             numbers.RemoveAt(numbers[i]);
                    //             numbers.RemoveAt(numbers[i + 1]);
                    //         }
                    //         // else
                    //         // {
                    //         //     currentSum = firstNum + secondNum;
                    //         // }
                    //         break;
                    //     case 10:
                    //         if (firstNum == 1)
                    //         {
                    //             currentSum = 9;
                    //             numbers.RemoveAt(numbers[i]);
                    //             numbers.RemoveAt(numbers[i + 1]);
                    //         }
                    //         // else
                    //         // {
                    //         //     currentSum = firstNum + secondNum;
                    //         // }
                    //         break;
                    //     case 50:
                    //         if (firstNum == 10)
                    //         {
                    //             currentSum = 40;
                    //             numbers.RemoveAt(numbers[i]);
                    //             numbers.RemoveAt(numbers[i + 1]);
                    //         }
                    //         // else
                    //         // {
                    //         //     currentSum = firstNum + secondNum;
                    //         // }
                    //         break;
                    //     case 100:
                    //         if (firstNum == 10)
                    //         {
                    //             currentSum = 90;
                    //             numbers.RemoveAt(numbers[i]);
                    //             numbers.RemoveAt(numbers[i + 1]);
                    //         }
                    //         // else
                    //         // {
                    //         //     currentSum = firstNum + secondNum;
                    //         // }
                    //         break;
                    //     case 500:
                    //         if (firstNum == 100)
                    //         {
                    //             currentSum = 400;
                    //             numbers.RemoveAt(numbers[i]);
                    //             numbers.RemoveAt(numbers[i + 1]);
                    //         }
                    //         // else
                    //         // {
                    //         //     currentSum = firstNum + secondNum;
                    //         // }
                    //         break;
                    //     case 1000:
                    //         if (firstNum == 100)
                    //         {
                    //             currentSum = 900;
                    //             numbers.RemoveAt(numbers[i]);
                    //             numbers.RemoveAt(numbers[i + 1]);
                    //         }
                    //         // else
                    //         // {
                    //         //     currentSum = firstNum + secondNum;
                    //         // }
                    //         break;
                    //         // default:
                    //         //     currentSum = firstNum + secondNum;
                    //         //     break;

                    // }

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("that was out of range");
                    currentSum = firstNum;
                }
                sum += currentSum;

                Console.WriteLine($"sum: {sum}");
            }
        }

    }
}