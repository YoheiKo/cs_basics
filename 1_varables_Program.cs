using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ctrl + Shift + B to complile the file
            // Ctrl + F5 to run the program
            byte number = 2; // byte stors two to the power of 8 amount of data (eight bits)
            int count = 10; // inte is four bytes (8 x 4 = 32 bits)

            // C# treat real numbers as doubles. If you want to use float you have to spedicy it
            float totalPrice = 20.95f;

            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            // instead of explicity defining the datatype, we can simply type var
            // You can see the underlyng data type by hovering over the datatype
            var numberTwo = 4;
            var countTwo = 20;
            var totalPriceTwo = 20.95;
            var characterTwo = 'B';
            var secondName = "Matt";
            var isWorkingTwo = true;

            // define a constant by cons keyword
            const float Pi = 3.14f;
       
        



            // Console is the class inside the System namespace
            Console.WriteLine(number);
            // Press cw and tab key (code snipper)
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine(numberTwo);
            Console.WriteLine(countTwo);
            Console.WriteLine(totalPriceTwo);
            Console.WriteLine(characterTwo);
            Console.WriteLine(secondName);
            Console.WriteLine(isWorkingTwo);

            // set placeholders in a string (format string). 
            // you will have 0 and 255
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);


            // imp

        }
    }
}
