using System;
using System.Text;

namespace ReplaceEmptySpace
{
    class Program
    {
        const String CONSCHAR = "%20";
        static void Main(string[] args)
        {
            replaceChar("Hello World!");
        }

        static void replaceChar(string sentence){
            char [] chars = sentence.ToCharArray();
            StringBuilder sb = new StringBuilder(); 

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == (char) 32) {
                    sb.Append(CONSCHAR);
                }else{
                    sb.Append(chars[i]);
                }
            }

            System.Console.WriteLine(sb.ToString());
        }
    }
}
