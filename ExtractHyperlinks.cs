using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem6_ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            while (line!="END")
            {
                text.Append(line);
                line=Console.ReadLine();
            }
            string pattern = @"<a[^>]*href *=\s*(""[^""]*""|'[^']*'|[^ >]*)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text.ToString());
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value.Trim(new char[] { '"','\''}));  
            }
        }
    }
}
