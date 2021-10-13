using System;
using System.Text;

namespace ReplaceEmptySpace
{
    class Program
    {
        const String CONSCHAR = "%20";
        static void Main(string[] args)
        {
            replaceChar("Hello  World!");
        }

        static void replaceChar(string sentence) 
        {
            StringBuilder sb = new StringBuilder(); 

            foreach (var chr in sentence) {
                if (chr == (char) ' ') 
                    sb.Append(CONSCHAR);
                else
                    sb.Append(chr);      
            }

            System.Console.WriteLine(sb.ToString());
        }
    }
}
