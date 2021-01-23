using System;
using System.Linq;

namespace DefangIp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: 111.111.111.111");
            Defang("111.111.111.111");
        }
        public static string Defang(string address)
        {
            string[] addressArray = address.Split(".");
            string defanged = string.Join("[.]", addressArray);
            Console.Write("output: ");
            Console.Write(defanged);
            return defanged;
        }
    }
}