// See https://aka.ms/new-console-template for more information
namespace ConsoleAppDemo
{
    internal class multiplication
    {
        public static void Main()
        {
            int a, b, c, mul;
            Console.Write("First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number");
            c = Convert.ToInt32(Console.ReadLine());
            mul = a * b * c;
            Console.WriteLine("Product of three number" + mul);
        }
    }
}
