using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//using (var reader = new StringReader(multiLineString)) ;


namespace zadanka
{
    public class NumbersFromText
    {
        private string convertToNum (string text)
        {
            string num = text;
            if (text == "zero") num = "0";
            else if (text == "one") num = "1";
            else if(text == "two") num = "2";
            else if(text == "three") num = "3";
            else if(text == "four") num = "4";
            else if(text == "five") num = "5";
            else if(text == "six") num = "6";
            else if(text == "seven") num = "7";
            else if(text == "eight") num = "8";
            else if(text == "nine") num = "9";
            return num;
        }
        public int ExstractNumbers(string text)
        {
                string resStr;
                Regex rx = new Regex(@"[1-9]|(one)|(two)|(three)|(four)|(five)|(six)|(seven)|(eight)|(nine)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                MatchCollection matches = rx.Matches(text);
                resStr = convertToNum(matches.First().ToString()) + convertToNum(matches.Last().ToString());
                return int.Parse(resStr);

        }

        public int AddNumbers(string text)
        {
            int res = 0;
            using (var reader = new StringReader(text))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    int num = ExstractNumbers(line);
                    res += num;
                }
            }
            return res;
        }
    }
}