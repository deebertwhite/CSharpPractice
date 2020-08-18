using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Submission
    {
        public static Student Test1(string last, string first, int idNo)
        {
            Student newStudent = new Student();
            return newStudent;
        }

        public static Student Test2(string last, string first, int idNo)
        {
            Student newStudent = new Student();
            return newStudent;
        }

        public static bool Test3(Student[] enrollment, Student enrolled)
        {
            bool isEnrolled = false;
            if (enrollment == null)
            {
                enrollment[0] = enrolled;
                isEnrolled = true;
            }
            return isEnrolled;

        }

        public static bool Test4(Student[] enrollment, int idNumber)
        {
            bool isRemoved = false;
            for (int i = 0; i >= enrollment.Length; i++)
            {
                if (enrollment[i].GetIDNumber() == idNumber)
                {
                    enrollment[i].SetIDNumber(0);
                    isRemoved = true;
                }
            }
            return isRemoved;
        }

        public static Student Test5(Student[] enrollment, int idNumber)
        {
            string found = null;
            for (int i = 0; i >= enrollment.Length; i++)
            {
                if (enrollment[i].GetIDNumber() == idNumber)
                {
                    found = enrollment[i].GetFirstName();
                }
            }
            return null;
        }
    }
}
