using CSharpFundamentals.Math; //add the namasepace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator(); // allocate mamory
            var result = calculator.Add(1, 2);

            // Because the cw method is defined as static, you do not have to create a new Console instance(object) of Console class
            // to call the cw method 
            Console.WriteLine(result);

            /////////////////////////////

            // create an array. numbers is an identifier
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // boolean array
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "jack", "John", "Mary" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            /////////////////////////////

            // String which is a class on the system namespace. primiive types e.g. int are srucures. 
            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;

            // format is a static method of string class
            // Statis methods arw accessible without a need to create an object
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            // .Join is also a static method on the string class
            var namesTwo = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", namesTwo); // separator, array
            Console.WriteLine(formattedNames);

            var text = "Hi John \nLook into the following paths \nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder3";
            Console.WriteLine(text2);

            /////////////////////////////

            var method = ShippingMethod.Express;

            Console.WriteLine(((int)method)); //casting

            var methodId = 3; // we want to convert this to ShippingMethod using casting
            Console.WriteLine((ShippingMethod)methodId);


            Console.WriteLine(method.ToString());

            // string to enum
            var methodName = "Express";
            //parsing converts string to a different type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            /////////////////////////////

            var a = 10;
            var b = a;
            b++; //icrement operator

            //integeres are value types (values are coppied. a and b are independent)
            Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));

            // array is reference type (the memory address is the same)
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0])); //Both are zero

            /////////////////////////////

            // Value type
            var number = 1; // this is inside the scope of main method. It does not have meaning outside
            Increment(number); // because int is a value type, the number is still 1. number inside the Increment has a different place in memory 
            Console.WriteLine(number); // 1

            // Ref type sharing the seme reference (memory) in the heap
            var person = new PersonTwo() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);




        }
        // Increment method
        public static void Increment(int number)
        {
            number += 10;
        }

        // MakeOld method
        // void means returns nothing
        // statc enable the method to be called without createing an object 
        public static void MakeOld(PersonTwo person)
        {
            person.Age += 10;

        }
    }

    // We need to create a Class or enum at a namespace level
    // enums is a set of name/values pairs
    // Use enum when you have numbers of related constants
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class PersonTwo
    {
        public int Age;
    }
    
    // To create a new file, go to solution explorer, right click + add + class and name it in the bottom of the new window
     

        
}
