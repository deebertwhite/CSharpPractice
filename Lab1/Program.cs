using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Full Sail!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            String age = Console.ReadLine();
            Console.WriteLine("Nice to meet you " 
                + name + ". Congradulations on surviving to the lovely age of " 
                + age + "!");
            Console.ReadKey();
        }
    }
}
