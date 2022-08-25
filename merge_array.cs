using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingments
{
    internal class merge_array
    {
        public static void Main()
        {
            int i = 0, j = 0;
            int[] arr1 = new int[5] { 1, 2, 3, 4,5 };
            int[] arr2 = new int[5] { 6, 7, 8,9,10 };
            int[] merged = new int[10];

            for (i = 0, j = 0; i < 5; i++)
            {
                merged[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merged[j++] = arr2[i];
            }
            Console.WriteLine("Elements of merged array = ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
            }
            Console.WriteLine();
        }
    }
}
    

