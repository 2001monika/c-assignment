using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingments
{
    internal class words
    {
        public static void Main()
        {
            int a = 0, w = 1;
            string str = "Hello World!";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    w++;
                }
                a++;
            }
            Console.Write("Number of words in the string = {0}\n", w);
        }
    }
    
}
