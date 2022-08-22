using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingments
{
    internal class age
    {
        public static void Main()
        {
            Console.Write("Input your current age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your age after 10 years:");
            age = age + 10;
            Console.Write("{0} ", age);
        }
    }
}
