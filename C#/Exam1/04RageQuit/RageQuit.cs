using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);

            MatchCollection matches = Regex.Matches(input,pattern);

            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                StringBuilder sb = new StringBuilder();
                var message = match.Groups[1].Value.ToUpper();
                var numberOfRepetitions = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < numberOfRepetitions; i++)
                {
                    sb.Append(message);
                }

                builder.Append(sb);
            }
            var set = new HashSet<char>();

            foreach (char ch in builder.ToString())
            {
                set.Add(ch);
            }
            Console.WriteLine("Unique symbols used: {0}", set.Count());
            Console.WriteLine(builder);

        }
    }
}
