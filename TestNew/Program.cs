using System;

namespace TestNew
{
    class Program
    {
        static void Main()
        {
            Console.Write("My name is James White. What Is your name?\n");
            string name = Console.ReadLine();
            Console.Write("Great to meet you, " + name + ". How old are you?\n");
            string input = Console.ReadLine();
            int age = Int32.Parse(input);
            Console.Clear();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
