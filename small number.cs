using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingments
{
    internal class small_number
    {
        public static void Main()
        {
            Console.Write("First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int min;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }
            Console.WriteLine("Small number " + min);
        }
    }
}
