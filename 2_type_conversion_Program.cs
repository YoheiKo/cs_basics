using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte is 1 byte and int has four bytes. We can copy byte to int
            // implicit conversion
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            // You can implicitly convert int to byte
            // (byte) is the explicit conversion called cast
            // if you assign 1000 to int and cast it, bits will be lost. The outcome is not 1000
            int iTwo = 2;
            byte bTwo = (byte) iTwo;

            Console.WriteLine(bTwo);

            /////////////////////////////////

            // Non-compatible type
            var number = "1234";

            // We cannot cast string to int
            // Use Convert class, Toint32 method and pass number as an argument
            int iThird = Convert.ToInt32(number);

            Console.WriteLine(iThird);

            /////////////////////////////////

            try
            {
                // This code will crash. We can handle exception by wrapping by try
                var numberTwo = "1248";
                byte bThird = Convert.ToByte(numberTwo);
                Console.WriteLine(bThird);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be ocnverted to a byte");
            }

            /////////////////////////////////

            try
            {
                var str = "true";
                bool bForth = Convert.ToBoolean(str);
                Console.WriteLine(bForth);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be ocnverted to a byte");
            }
        }
    }
}
