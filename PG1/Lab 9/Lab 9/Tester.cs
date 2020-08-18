using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Tester
    {
        private static int idNum = 1000000;
        private static string[] fNames = new string[30];
        private static string[] lNames = new string[30];
        private static int[] idNos = new int[30];
        private static int ndx = 0;

        public static void Run()
        {
            GenerateNames();
            Random rng = new Random();
            PopulateIDs(rng);
            Student r = null;
            int passNumber = 1;
            Console.Clear();
            Console.WriteLine("\n\tTest #1\n");
            for (int cntr = 0; cntr < 5; cntr++)
            {
                r = Submission.Test1(lNames[rng.Next(30)], fNames[rng.Next(30)], idNos[ndx++]);
                if (r!= null && r.GetType() == typeof(Student))
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + r);
                }
                else
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + "Invalid type returned...");
                }
            }
            ndx = 29;
            Console.WriteLine();
            passNumber = 1;
            Console.WriteLine("\n\tTest #2\n");
            for (int cntr = 0; cntr < 5; cntr++)
            {
                r = Submission.Test2("", "", 0);
                if (r!=null && r.GetType() == typeof(Student))
                {
                    r.SetLastName(lNames[rng.Next(30)]);
                    r.SetFirstName(fNames[rng.Next(30)]);
                    r.SetIDNumber(idNos[ndx--]);
                    Console.WriteLine("Pass " + passNumber++ + ": " + r);
                }
            }

            Console.WriteLine();
            passNumber = 1;
            Console.WriteLine("\n\tTest #3\n");
            for (int cntr = 0;cntr < 5; cntr++)
            {
                Student [] kids = GenerateRandomArray(rng);
                Student s = new Student(lNames[rng.Next(30)], fNames[rng.Next(30)], idNos[29 - cntr]);
                bool result = Submission.Test3(kids, s);
                if(result)
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + "Added:\t\t" + s);
                }
                else
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + "Could not add\t" + s);
                }
            }

            Console.WriteLine();
            passNumber = 1;
            Console.WriteLine("\n\tTest #4\n");
            for (int cntr = 0; cntr < 5; cntr++)
            {
                Student[] kids = GenerateRandomArray(rng);
                int inThere = rng.Next() % 7;
                // Student s = new Student();
                int idNo = 0;
                int startHere = rng.Next(0, kids.Length);
                if(inThere!=0)
                {
                    for(int count=startHere;count<kids.Length;count++)
                    {
                        if (kids[count] != null)
                        {
                            idNo = kids[count].GetIDNumber();
                            break;
                        }
                    }
                }
                bool result = Submission.Test4(kids, idNo);
                if (result)
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + "Student ID # " + idNo + " removed...");
                }
                else
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + "Could not remove, Student ID not found...");
                }
            }
            Console.WriteLine();
            passNumber = 1;
            Console.WriteLine("\n\tTest #5\n");
            for (int cntr = 0; cntr < 5; cntr++)
            {
                Student[] kids = GenerateRandomArray(rng);
                int inThere = rng.Next() % 7;
                // Student s = new Student();
                int idNo = 0;
                int startHere = rng.Next(0, kids.Length);
                if (inThere != 0)
                {
                    for (int count = startHere; count < kids.Length; count++)
                    {
                        if (kids[count] != null)
                        {
                            idNo = kids[count].GetIDNumber();
                            break;
                        }
                    }
                }
                Student s = Submission.Test5(kids, idNo);
                if (s != null)
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + s);
                }
                else
                {
                    Console.WriteLine("Pass " + passNumber++ + ": " + "Student not found...");
                }

            }
            Console.WriteLine();
        }
        private static void PopulateIDs(Random rng)
        {
            int lastNumber = 0;
            for (int cntr = 0; cntr < idNos.Length; cntr++)
            {
                lastNumber = rng.Next(lastNumber, lastNumber + 500);
                idNos[cntr] = idNum + lastNumber;
            }
        }
        static void GenerateNames()
        {
            lNames[0] = "Hanover";
            lNames[1] = "Gomez";
            lNames[2] = "Swayze";
            lNames[3] = "Chan";
            lNames[4] = "McDeevers";
            lNames[5] = "Johnson";
            lNames[6] = "St. Pierre";
            lNames[7] = "Rodriquez";
            lNames[8] = "Moskovitz";
            lNames[9] = "Stalin";
            lNames[10] = "Jones";
            lNames[11] = "Smythe";
            lNames[12] = "Bell";
            lNames[13] = "Fisher";
            lNames[14] = "Nettles";
            lNames[15] = "Allen";
            lNames[16] = "Harrison";
            lNames[17] = "Roberts";
            lNames[18] = "Neilsen";
            lNames[19] = "Starkey";
            lNames[20] = "Stanley";
            lNames[21] = "Marshall";
            lNames[22] = "Butt";
            lNames[23] = "Penney";
            lNames[24] = "Cox";
            lNames[25] = "Bauer";
            lNames[26] = "Martinez";
            lNames[27] = "McCartney";
            lNames[28] = "Frazier";
            lNames[29] = "Lennon";

            fNames[0] = "Allison";
            fNames[1] = "Bradley";
            fNames[2] = "Cheryl";
            fNames[3] = "Daniel";
            fNames[4] = "Esther";
            fNames[5] = "Fernando";
            fNames[6] = "Gloria";
            fNames[7] = "Harvey";
            fNames[8] = "Irene";
            fNames[9] = "Jeremy";
            fNames[10] = "Kaitlyn";
            fNames[11] = "Lawrence";
            fNames[12] = "Marsha";
            fNames[13] = "Nicolai";
            fNames[14] = "Olivia";
            fNames[15] = "Percy";
            fNames[16] = "Quinton";
            fNames[17] = "Roseanne";
            fNames[18] = "Suzanna";
            fNames[19] = "Trevor";
            fNames[20] = "Ulysses";
            fNames[21] = "Velma";
            fNames[22] = "Wanda";
            fNames[23] = "Xavier";
            fNames[24] = "Yahpet";
            fNames[25] = "Zondra";
            fNames[26] = "John";
            fNames[27] = "Paul";
            fNames[28] = "George";
            fNames[29] = "Richard";
        }

        private static Student [] GenerateRandomArray(Random rng)
        {
            Student[] students = new Student[rng.Next(5, 16)];
            for(int cntr=0;cntr<students.Length;cntr++)
            {
                int nullOrNot = rng.Next() % 7;
                if(nullOrNot==0)
                {
                    students[cntr] = null;
                }
                else
                {
                    students[cntr] = new Student(lNames[rng.Next(30)], fNames[rng.Next(30)], idNos[cntr]);
                }
            }
            return students;
        }

    }
}
