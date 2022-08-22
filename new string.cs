using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingments
{
    internal class new_string
    {
        public static void Main()
        {
            Console.WriteLine(first_last("moni"));
            Console.WriteLine(first_last("manas"));
            Console.WriteLine(first_last("sweet"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
