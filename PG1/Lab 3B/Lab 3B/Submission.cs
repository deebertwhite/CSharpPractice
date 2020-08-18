using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         */

        private string greeting;
        private int appointmentTime;

        public Submission()
        {
            greeting = "Good day";
            appointmentTime = 7;
        }

        // Test 1 - write an overloaded constructor that will accept 
        // a string value to intialize greeting

        public Submission(string greet)
        {
            greeting = greet;
        }

        // Test 2 - Write a getter for greeting (GetGreeting)

        public string GetGreeting()
        {
            return greeting;
        }

        // Test 3 - Write a setter for greeting (SetGreeting)
        public void SetGreeting(string greet)
        {
            greeting = greet;
        }

        // Test 4 - Write a property for appointmentTime named Rendezvous

        public int Rendezvous
        {
            get { return appointmentTime; }
            set { appointmentTime = value; }
        }

        // Test 5 - Write a method named GreetingMe that accepts
        // no parameters and returns the value of greeting as 
        // all capital letters - Use the ToUpper method

        public string GreetingMe() 
        {
            return greeting.ToUpper();
        }
        // Test 6 - Complete the method so that it returns 
        // the input value raised to the 3rd power (use  
        // Math.Pow and cast the returned value to int)
        public static int Test6(int input)
        {
            return (int) Math.Pow(input,3);
        }

        // Test 7 - Complete the method so that it returns
        // the square root of the input value as a double
        // Use Math.Sqrt to find the square root
        public static double Test7(float input)
        {
            return (double) Math.Sqrt(input);
        }

        // Test 8 - Complete the method so that it returns 
        // the quotient when number1 is divided by number2

        public static int Test8(int number1, int number2)
        {
            return number1 / number2;
        }

        // Test 9 - Complete the method so that it return
        // the remainder when number1 is divided by number2

        public static int Test9(int number1, int number2)
        {
            return number1 % number2;
        }

        // Test 10 - Complete the method so that it returns
        // a random int based on the seed provided, The return
        // value must be between min (inclusive) and max 
        // (exclusive)

        public static int Test10(int min, int max, int seed)
        {
            Random gen = new Random(seed);
            return gen.Next(min, max);
        }
    }
}
