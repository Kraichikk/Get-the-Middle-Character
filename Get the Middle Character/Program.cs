using System;

namespace Get_the_Middle_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("pilika"));
        }
        public static string GetMiddle(string s)
        {
            string str = "";
            char[] cArr = s.ToCharArray();
            if (s.Length % 2 != 0)
            {
                str += cArr[s.Length / 2 ];
                return str;
            }
            else
            {
                str += cArr[cArr.Length  / 2 - 1];
                str += cArr[cArr.Length / 2 ];
                return str;
            }
        }
    }
}
