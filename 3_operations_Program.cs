using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);

            // The result is three because a and b are int
            // If you want float, you need to cast int to float
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);

            ///////////////////////////

            var c = 1;
            var d = 2;
            var e = 3;

            Console.WriteLine(c + d * e);
            Console.WriteLine((c + d) * e);
            Console.WriteLine(c > d);
            Console.WriteLine(c == d);
            Console.WriteLine(c != d); // True
            Console.WriteLine(e > d && e > c); // True && True equals True
            Console.WriteLine(e > d && c == a); // True && False equals False
            Console.WriteLine(e > d || c == a); // True || False equals True

            ///////////////////////////





        }
    }
}
