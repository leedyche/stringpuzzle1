using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPuzzle
{
    public class StringPuzzle
    {
        //used an array to ensure the order is set 
        public static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        //fast lookup no need for nested loops
        public static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        public static string Solve(string input)
        {

            //check for blank input
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            //not really needed here but good practice 
            StringBuilder sb = new StringBuilder();

            char earliestChar = '-';

            string reverse = "";
            int vowelCount = 0;

            //ive gone for a loop hear to make it more efficient, as i can reverse the string, count vowels and find the earliest all in one pass
            foreach (char c in input)
            {
                reverse = c + reverse;
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }

                //assuming that earliest is alpabetical
                if (earliestChar == '-' || c < earliestChar)
                {
                    earliestChar = c;
                }
            }

            sb.Append(reverse);
            sb.Append(earliestChar);

            if (vowelCount % 2 > 0)
            {
                sb.Append("open");
            }
            else
            {
                sb.Append("rent");
            }

            return sb.ToString();
        }



    }
}
