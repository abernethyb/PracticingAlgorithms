using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class Program
    {

        static void Main(string[] args)
        {
            string ucChoice = "";
            while (ucChoice != "N" && ucChoice != "I" && ucChoice != "Q")
            {
                Console.WriteLine("Welcome.  You are either about to convert a number to a roman numeral or a roman numeral to a number. Choose wisely.");
                Console.WriteLine("");
                Console.WriteLine("enter n to convert from numerals or i to convert from a number.");
                Console.WriteLine("");
                Console.Write("What is your choice: ");
                string choice = Console.ReadLine();
                ucChoice = choice.ToUpper();

            }

            if (ucChoice == "N")
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
                        RomanToNumber.RomanToInt(upperCaseInputNumeral);

                        // ///debugging int to numeral
                        // string strIntInput = Console.ReadLine();
                        // int intInput = Int32.Parse(strIntInput);
                        // Console.WriteLine("intconverter");
                        // NumberToRoman.IntToRoman(intInput);
                        // ///

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
            else
            {
                Console.WriteLine("Convert a number to roman numerals.");
                Console.WriteLine("press q to quit");
                string inputNumber = "";
                while (inputNumber != "Q" && inputNumber != "q")
                {
                    Console.Write("Enter a number: ");
                    inputNumber = Console.ReadLine();
                    if (inputNumber != "Q" && inputNumber != "q")
                    {
                        try
                        {
                            int intNumber = Int32.Parse(inputNumber);

                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write($"You Entered: {inputNumber} ");
                            Console.WriteLine("");
                            Console.Beep();

                            ///debugging int to numeral
                            // string strIntInput = Console.ReadLine();
                            // int intInput = Int32.Parse(strIntInput);
                            // Console.WriteLine("intconverter");
                            NumberToRoman.IntToRoman(intNumber);
                            ///

                            Console.WriteLine("");
                            Console.WriteLine("press q to quit");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine($"You entered {inputNumber}. That is not a number.  Enter a number: ");
                        }

                    }

                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                    }

                }
            }

        }

    }

}