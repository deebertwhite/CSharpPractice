using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Student
    {
        // Add member fields here

        private string lastName;
        private string firstName;
        private int idNo;

        // Add default and overloaded constructors here
        public Student()
        {
            lastName = "";
            firstName = "";
            idNo = 1000000;
        }

        public Student(string last, string first, int id)
        {
            lastName = last;
            firstName = first;
            idNo = id;
        }


        // add Getters and Setters here

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetIDNumber()
        {
            return idNo;
        }

        public void SetFirstName(string first)
        {
            firstName = first;
        }

        public void SetLastName(string last)
        {
            lastName = last;
        }

        public void SetIDNumber(int id)
        {
            idNo = id;
        }

        // do not modify any of the following code
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + 
                                                   ", " + GetFirstName();
        }
    }
}
