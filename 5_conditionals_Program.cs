using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{

    class Program
    {   
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12) //And
                Console.WriteLine("It's morning");

            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");

            else
                Console.WriteLine("It's evening");

            //////////////////////////

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;

            else
                price = 29.95f;

            Console.WriteLine(price);

            //////////////////////////

            // This yealds the same
            float priceTwo = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(priceTwo);

            ////////////////////////

            // create a new class
            // alt + Enter to make use of resharper

            var season = Season.Autum;

            switch (season)
            {
                case Season.Autum: //if statement
                    Console.WriteLine("It's Autum");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;

                default:
                    Console.WriteLine("I don't understand the season");
                    break;

            }

            switch (season)
            {
                case Season.Autum: //if statement
                case Season.Summer: //Or another if statemnet
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand the season");
                    break;

            }

            //Exam1 Vaild or Invalid////////////////////////

            Console.WriteLine("Enter a number beween 0 and 10");
            var inputNum = Console.ReadLine();
            var inputNumber = Convert.ToInt32(inputNum);

            if (inputNumber >=0 && inputNumber <= 10)
                Console.WriteLine("Valid input");

            else
                Console.WriteLine("Invalid");

            //Exam2 max of two inputs////////////////////////

            Console.WriteLine("Enter a number");
            var inputNum1 = Console.ReadLine();
            var inputNumber1 = Convert.ToInt32(inputNum1);

            Console.WriteLine("\n------------------");

            Console.WriteLine("Enter another number");
            var inputNum2 = Console.ReadLine();
            var inputNumber2 = Convert.ToInt32(inputNum2);

            if (inputNumber1 >= inputNumber2)
                Console.WriteLine(inputNumber1);

            else
                Console.WriteLine(inputNumber2);

            Console.WriteLine("\n------------------");

            //Exam3 Landscape or Portrait////////////////////////

            Console.WriteLine("Enter the width of the rectangle");
            var inputNum3 = Console.ReadLine();
            var inputNumber3 = Convert.ToInt32(inputNum3);

            Console.WriteLine("\n------------------");

            Console.WriteLine("Enter the height of the rectangle");
            var inputNum4 = Console.ReadLine();
            var inputNumber4 = Convert.ToInt32(inputNum4);

            if (inputNumber3 > inputNumber4)
                Console.WriteLine("It's a lanscape shape");
            
            else if (inputNumber3 < inputNumber4)
                Console.WriteLine("It's a portrait shape");

            else
                Console.WriteLine("It's a square");

            Console.WriteLine("\n------------------");

            //Exam4 Speed limit////////////////////////

            int speedLimit = 100;
            int demPoints;

            Console.WriteLine("What is the speed of your car?");
            var inputNum5 = Console.ReadLine();
            var inputNumber5 = Convert.ToInt32(inputNum5);
            demPoints = (inputNumber5 - speedLimit) / 5;

            if (speedLimit >= inputNumber5)
                Console.WriteLine("Ok, within the limit.");

            else if (demPoints <= 12)
                Console.WriteLine(string.Format("Exceed the limit. The demeritpoint is {0}", demPoints));

            else
                Console.WriteLine(string.Format("Exceed the limit. Liscense is suspended. The demeritpoint is {0}", demPoints));



        }

        ////////////////////////////////////
        /// <Model answer>
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        public void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Exercise2()
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public void Exercise3()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public void Exercise4()
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit)/kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}