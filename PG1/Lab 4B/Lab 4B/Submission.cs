using FS_Supplemental;
using System.ComponentModel;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * */

        // Given two ints, num1 and num2, determine if num1 is a multiple of num2. 
        // If it is a multiple return true, otherwise, return false.
        public static bool Test1(int num1, int num2)
        {
            bool multiple = false;
            if(num1 % num2 == 0)
            {
                multiple = true;
            }
            return multiple;
        }

        // Given two doubles, fahrenheit and celsius, determine if they are equal temperatures. 
        // The formula to convert Fahrenheit to Celsius is:
        // Celsius = (Fahrenheit – 32.0) * (5.0/9.0)
        // The formula to convert Celsius to Fahrenheit to Celsius is:
        // Fahrenheit = (Celsius* 9.0 / 5.0) + 32.0
        public static bool Test2(double fahrenheit, double celsius)
        {
            bool EqualTemp = false;
            if (celsius == ((fahrenheit - 32.0) * (5.0 / 9.0)))
            { 
                return true;
            }
            return EqualTemp;
        }

        // Given the grade variable, which indicates a student's numeric grade, 
        // determine which letter grade they should receive. Return the proper 
        // letter (char) as the result of this test. Do not worry about rounding 
        // the grade. Use the following table to indicate which letter corresponds 
        // to provided grades.
        // Use if and else-if for Test3
        // Remember only one return statement is allowed
        //  >= 90 and <= 100 	'A'
        //  >= 80 and< 90 	    'B'
        //  >= 73 and< 80    	'C'
        //  >= 70 and< 73 	    'D'
        //  >= 0 and< 70 	    'F'
        //  < 0 or> 100 	    '?'

        public static char Test3(double grade)
        {
            char LetterGrade = '~';
            if (grade >= 90 && grade <= 100 )
            {
                LetterGrade = 'A';
            }
            else if (grade >= 80 && grade < 90)
            { 
                LetterGrade = 'B';
            }
            else if (grade >= 73 && grade < 80)
            {
                LetterGrade = 'C';
            }
            else if (grade >= 70 && grade < 73)
            {
                LetterGrade = 'D';
            }
            else if (grade >= 0 && grade < 70)
            {
                LetterGrade = 'F';
            }
            else if (grade < 0 || grade > 100)
            {
                LetterGrade = '?';
            }
            return LetterGrade;
        }

        // Given two doubles (num1 and num2) and a MathOperator, an enum,
        // value that indicates a math operation, perform the appropriate 
        // math operation on the two numbers and return the result. The 
        // MathOperator enum has already been defined (so you do not need 
        // to redefine it). It's values are: Add, Subtract, Multiple, Divide
        // Use a switch for Test4
        // Remember only one return statement is allowed
        public static double Test4(double number1, double number2, MathOperator op)
        {
            double answer = 0;
            switch(op)
            {
                case MathOperator.Add:
                    answer = number1 + number2;
                    break;
                case MathOperator.Subtract:
                    answer = number1 - number2;
                    break;
                case MathOperator.Multiply:
                    answer = number1 * number2;
                    break;
                case MathOperator.Divide:
                    answer = number1 / number2;
                    break;
            }
            return answer;
        }

        // Given an int, speed, and the following decision table, determine 
        // what action should be taken.Return the number that represents the 
        // action from the table
        // 0 - verbal warning
        // 1 - written warning
        // 2 - citation
        // 3 - take into custody
        // You cannot use multiple return statements in this method

        public static int Test5(int speed)
        {
            int action = 0;
            if (speed <= 5) 
            {
                action = 0;
            }
            else if (speed <= 10 && speed > 5)
            {
                action = 1;
            }
            else if (speed <= 25 && speed > 10)
            {
                action = 2;
            }
            else if (speed > 25)
            {
                action = 3;
            }
            return action;
        }

        // Given two Point objects, determine if they two Point objects 
        // are equal. The Point class provides an 'Equals' method that 
        // can be used to determine if a Point is equal to a second point. 
        // The Equals method signature is:
        // bool Equals(object obj)
        public static bool Test6(Point p1, Point p2)
        {
            bool point = false;
            if (Equals(p1, p2))
            {
                point = true;
            }
            return point;
        }

        // Given three doubles that represent the cost of an item, the         
        // applicable tax rate for the item and cash on hand, determine 
        // if cash on hands will cover the cost of the item. Return true 
        // if the item can be purchased, otherwise return false
        public static bool Test7(double price, double taxRate, double cashOnHand)
        {
            bool affordable = true;
            double total = price + (price * taxRate);
            if (total > cashOnHand)
            {
                affordable = false;
            }
            return affordable;
        }

        // Given a distance in miles and a distance in kilometers, determine
        // which is the greater distance. Return the value of the greater 
        // distance. Use the conversion factor:
        // 1km = 0.621 miles (1 mile = 1.609km)
        public static double Test8(double miles, double kilometers)
        {
            double GreaterDistance = miles;
            if (kilometers > (miles * 1.609))
            {
                GreaterDistance = kilometers;
            }
            else
            {
                GreaterDistance = miles;
            }
            return GreaterDistance;
        }
    }
}
