using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class NumberToRoman
    {
        public static string IntToRoman(int inputInt)
        {
            //list to hold numerals
            List<string> numeralList = new List<string> { };

            int inputRemainder = inputInt;

            //loop to subtract and add numerals to array

            while (inputRemainder > 0)
            {
                while (inputRemainder >= 1000)
                {
                    inputRemainder = inputRemainder - 1000;
                    numeralList.Add("M");
                }
                while (inputRemainder >= 900)
                {
                    inputRemainder = inputRemainder - 900;
                    numeralList.Add("CM");
                }
                while (inputRemainder >= 500)
                {
                    inputRemainder = inputRemainder - 500;
                    numeralList.Add("D");
                }
                while (inputRemainder >= 400)
                {
                    inputRemainder = inputRemainder - 400;
                    numeralList.Add("CD");
                }
                while (inputRemainder >= 100)
                {
                    inputRemainder = inputRemainder - 100;
                    numeralList.Add("C");
                }
                while (inputRemainder >= 90)
                {
                    inputRemainder = inputRemainder - 90;
                    numeralList.Add("XC");
                }
                while (inputRemainder >= 50)
                {
                    inputRemainder = inputRemainder - 50;
                    numeralList.Add("L");
                }
                while (inputRemainder >= 40)
                {
                    inputRemainder = inputRemainder - 40;
                    numeralList.Add("XL");
                }
                while (inputRemainder >= 10)
                {
                    inputRemainder = inputRemainder - 10;
                    numeralList.Add("X");
                }
                while (inputRemainder >= 9)
                {
                    inputRemainder = inputRemainder - 9;
                    numeralList.Add("IX");
                }
                while (inputRemainder >= 5)
                {
                    inputRemainder = inputRemainder - 5;
                    numeralList.Add("V");
                }
                while (inputRemainder >= 4)
                {
                    inputRemainder = inputRemainder - 4;
                    numeralList.Add("IV");
                }
                while (inputRemainder >= 1)
                {
                    inputRemainder = inputRemainder - 1;
                    numeralList.Add("I");
                }
            }

            //convert list to string 

            string numeral = string.Join("", numeralList);
            Console.Write("Numeral: ");
            Console.WriteLine(numeral);

            return numeral;
        }

    }
}