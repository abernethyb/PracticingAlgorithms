using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Convert roman numerals to numbers.");
            // Console.WriteLine("press q to quit");
            // string inputNumeral = "";
            // string upperCaseInputNumeral = "";
            // while (upperCaseInputNumeral != "Q")
            // {
            //     Console.Write("Enter a valid Roman Numeral: ");
            //     inputNumeral = Console.ReadLine();
            //     upperCaseInputNumeral = inputNumeral.ToUpper();

            //     if (upperCaseInputNumeral != "Q")
            //     {
            //         Console.WriteLine("");
            //         Console.WriteLine("");
            //         Console.Write($"You Entered: {upperCaseInputNumeral} ");
            //         Console.WriteLine("");
            //         Console.Beep();
            //         RomanToNumber.RomanToInt(upperCaseInputNumeral);

            ///debugging int to numeral
            string strIntInput = Console.ReadLine();
            int intInput = Int32.Parse(strIntInput);
            Console.WriteLine("intconverter");
            NumberToRoman.IntToRoman(intInput);
            ///

            //     Console.WriteLine("");
            //     Console.WriteLine("press q to quit");
            //     Console.WriteLine("");
            //     Console.WriteLine("");
            // }
            // else
            // {
            //     Console.WriteLine("Thanks for playing!");
            // }

            // }

        }

    }
}