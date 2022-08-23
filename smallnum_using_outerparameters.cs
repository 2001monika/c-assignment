using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class smallnum_using_outerparameters
    {
        public static void Num(int num1, int num2, out int result)
        {
            if (num1 < num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
        }
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter First Number");


            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Number");

            num2 = Convert.ToInt32(Console.ReadLine());


            Num(num1, num2, out int result);
            Console.WriteLine($"The smaller number is {result}");
        }




    }
}
