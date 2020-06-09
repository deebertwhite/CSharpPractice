using System;

// You are to debug this program by correcting any syntax errors so 
// the program will compile & execute 
// Additionally, you are to answer the questions in the accompanying 
// Debug Questions.docx Word document (it is in the same folder as
// the Debug Exercise.sln file

namespace Debug_Exercise
{
    class Program
    {
        static Random gener = new Random(Support.GetSeed());

        const int MIN = Support.MIN;
        const int MAX = Support.MAX;

        static string [] names = { "ybraD", "ecnerwaL", "haraS", "refinneJ", "yevaD" };

        static void Main(string[] args)
        {
            int age = Support.GetAge(gener.Next(MIN, MAX));
            string name = Support.GetName(names[gener.Next(names.Length)]);

            DisplayUserInfo(name, age);

            SayABCs();

            Console.ReadKey();
        }

        public static int Test3(string input)
        {
            return 0;
        }
        public static void DisplayUserInfo(string who, int old)
        {
            Console.Write("Please provide a warm welcome to my next guest, ");
            Console.WriteLine(who + ", on the occasion of turning " + old + " years old!");
        }

        public static void SayABCs()
        {
            for(int ndx = 97; ndx <= 122; ndx++)
            {
                if ((ndx + 3) % 10 == 0)
                {
                    Console.WriteLine();
                }
                if (ndx == 97)
                    Console.Write("\n" + (char)ndx + " ");
                else
                    Console.Write((char)ndx + " ");
            }
            Console.WriteLine();
        }
    }
}
