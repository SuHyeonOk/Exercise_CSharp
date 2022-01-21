using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_simple
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a; // 1
            a = b; // 2
            b = c; // 1
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"{a}, {b}");
        }
    }
}
