using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            string input = "g5";
            string pattern = @"(\D+)(\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("I ne vliza tuka?");
            }
    }
}
