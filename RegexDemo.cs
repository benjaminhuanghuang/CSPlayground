using System;
using System.Text.RegularExpressions;


namespace CSPlayground
{
    public class RegexDemo
    {
        public static void IsMatch()
        {

        }

        public static void FindFirst()
        {
            string text = "0 1 2 3 4 5 6 7 8 9";
            string pattern = @"[0-3,8]";
            Match m = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
            Console.WriteLine(m.Value);   // 0
        }
        public static void FindAll()
        {
            string text = "0 1 2 3 4 5 6 7 8 9";
            string pattern = @"[0-3,8]";
            MatchCollection mc = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            foreach (Match m in mc)
                Console.WriteLine(m.Value);  // 0 1 2 3 8
        }

        public static void Replace()
        {
            string text = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";

            Regex regex = new Regex(pattern); 
            string result = regex.Replace(text, replacement); 
            Console.WriteLine(string.Format("{0} was changed to {1}.", text, result));
        }

        public static void Split()
        {
            
        }
    }
}