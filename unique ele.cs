//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assingments
//{
//    internal class unique_ele
//    {
//        public static void Main()


//        {
//            int[] items = { 1, 3, 7, 5, 2, 1, 5, };
//            int n = items.Length;

//            Console.WriteLine("Unique array elements are: ");

//            for (int i = 0; i < n; i++)
//            {
//                bool correct = false;
//                for (int j = 0; j < i; j++)
//                {
//                    if (items[i] == items[j])
//                    {
//                        correct = true;
//                        break;
//                    }
//                }

//                if (!correct)
//                {
//                    Console.WriteLine(items[i]);

//                }
//            }

//            Console.ReadLine();
//        }
//    }
//}
