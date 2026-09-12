// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "(111 + 2) / 3";
            foreach (Match match in expParse(input))
            {
                Console.WriteLine(match.Value);
            }
        }

        static MatchCollection expParse(string input)
        {
            input = input.Replace(" ", "");
            Regex template = new Regex(@"\d+|(|)" + @"[\(\)\+\-\*\/]");
            return template.Matches(input);
        }
    }
}
