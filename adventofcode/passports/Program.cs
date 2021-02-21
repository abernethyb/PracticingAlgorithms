using System;
using System.Collections.Generic;
using System.Linq;

namespace passports
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            string commaInput = input.input.Replace("\r\n", ",");
            List<string> inputList = commaInput.Split(",,").ToList();
            List<Passport> passportList = new List<Passport> { };
            int validPassports = 0;


            foreach (string line in inputList)
            {
                List<string> keys = new List<string> { };

                string newline = line.Replace(",", ": ");

                Passport passport = new Passport();

                List<string> keyValues = newline.Split(" ").ToList();
                foreach (string kv in keyValues)
                {

                    string kvNoTrail = kv.Trim(new Char[] { ' ', ':' });
                    // Console.WriteLine(kvNoTrail);
                    List<string> keyvValue = kvNoTrail.Split(":").ToList();

                    string key = keyvValue[0];
                    string value = keyvValue[1];

                    if (key == "byr")
                    {
                        try
                        {
                            int intValue = Int32.Parse(value);
                            //byr (Birth Year) - four digits; at least 1920 and at most 2002.
                            if (intValue >= 1920 && intValue <= 2002)
                            {
                                passport.byr = intValue;
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    if (key == "iyr")
                    {
                        try
                        {
                            int intValue = Int32.Parse(value);
                            //iyr (Issue Year) - four digits; at least 2010 and at most 2020
                            if (intValue >= 2010 && intValue <= 2020)
                            {
                                passport.iyr = intValue;
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    if (key == "eyr")
                    {
                        try
                        {
                            int intValue = Int32.Parse(value);
                            //eyr (Expiration Year) - four digits; at least 2020 and at most 2030.
                            if (intValue >= 2020 && intValue <= 2030)
                            {
                                passport.eyr = intValue;
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    if (key == "hgt")
                    {
                        if (value.Contains("cm"))
                        {
                            string justNums = value.Remove(value.Length - 2);
                            try
                            {
                                int intValue = Int32.Parse(justNums);
                                //hgt (Height) - a number followed by either cm or in:
                                //If cm, the number must be at least 150 and at most 193.

                                //If in, the number must be at least 59 and at most 76.

                                if (intValue >= 150 && intValue <= 193)
                                {

                                    passport.hgt = intValue;
                                }
                            }
                            catch (Exception)
                            {

                            }

                        }
                        else if (value.Contains("in"))
                        {
                            string justNums = value.Remove(value.Length - 2);
                            try
                            {
                                int intValue = Int32.Parse(justNums);
                                //hgt (Height) - a number followed by either cm or in:
                                //If cm, the number must be at least 150 and at most 193.

                                //If in, the number must be at least 59 and at most 76.

                                if (intValue >= 59 && intValue <= 76)
                                {

                                    passport.hgt = intValue;
                                }
                            }
                            catch (Exception)
                            {

                            }

                        }

                    }
                    if (key == "hcl")
                    {
                        //hcl (Hair Color) - a # followed by exactly six characters 0-9 or a-f.
                        //[a-fA-F0-9]$  
                        if (value.StartsWith('#'))
                        {
                            char[] hclChar = value.ToCharArray();
                            char[] allowedChar = { 'a', 'b', 'c', 'd', 'e', 'f', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                            string validChars = "";
                            for (int i = 0; i < hclChar.Length; i++)
                            {

                                if (allowedChar.Contains(hclChar[i]))
                                {
                                    validChars += hclChar[i];
                                }

                            }
                            if (validChars.Length == 6)
                            {
                                passport.hcl = validChars;
                            }
                        }

                    }
                    if (key == "ecl")
                    {

                        //ecl (Eye Color) - exactly one of: amb blu brn gry grn hzl oth.
                        string[] allowedValues = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                        if (allowedValues.Contains(value))
                        {
                            passport.ecl = value;
                        }

                    }
                    if (key == "pid")
                    {
                        if (value.Length == 9)
                        {
                            try
                            {
                                int intValue = Int32.Parse(value);
                                //pid (Passport ID) - a nine-digit number, including leading zeroes.

                                passport.pid = intValue;

                            }
                            catch (Exception)
                            {

                            }
                        }
                    }

                }
                if (passport.pid != null && passport.hgt != null && passport.ecl != null && passport.iyr != null && passport.eyr != null && passport.byr != null && passport.hcl != null)
                {
                    passportList.Add(passport);
                    validPassports++;
                }

            }

            Console.WriteLine(validPassports);

        }
    }
}