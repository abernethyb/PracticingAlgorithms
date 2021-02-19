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
            int validPassports = 0;

            //Console.WriteLine(commaInput);

            //Console.WriteLine(input.input);

            foreach (string line in inputList)
            {
                List<string> keys = new List<string> { };
                // Console.WriteLine("top");
                // Console.WriteLine(line);

                string newline = line.Replace(",", ": ");
                string newlineTwo = newline.Replace(" ", ":");
                string newlineThree = newlineTwo.Replace("::", ":");

                List<string> keyValues = newlineThree.Split(":").ToList();
                //Console.WriteLine(newlineThree);
                foreach (string kv in keyValues)
                {
                    switch (kv)
                    {

                        case "ecl":
                            keys.Add(kv);
                            break;
                        case "pid":
                            keys.Add(kv);
                            break;
                        case "eyr":
                            keys.Add(kv);
                            break;
                        case "hcl":
                            keys.Add(kv);
                            break;
                        case "byr":
                            keys.Add(kv);
                            break;
                        case "iyr":
                            keys.Add(kv);
                            break;
                        case "cid":
                            keys.Add(kv);
                            break;
                        case "hgt":
                            keys.Add(kv);
                            break;

                    }

                    // Console.WriteLine("keytop");
                    // Console.WriteLine(kv);
                    // Console.WriteLine("keybottom");
                }

                // foreach (string key in keys)
                // {
                //     Console.WriteLine(key);
                // }

                // Console.WriteLine("bottom");
                // Console.WriteLine("");

                if (keys.Contains("ecl") && keys.Contains("pid") && keys.Contains("eyr") && keys.Contains("hcl") && keys.Contains("byr") && keys.Contains("iyr") && keys.Contains("hgt"))
                {
                    validPassports++;
                }
            }

            Console.WriteLine(validPassports);

        }
    }
}