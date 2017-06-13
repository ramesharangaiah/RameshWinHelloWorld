using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello " + CreateMessage() + " World" );
        }

        public static string CreateMessage()
        {
            string name;
            Console.WriteLine("Hello World!\n");
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Thanks for Entering your name");
            //return "Hello World Ramesh Rangaiah."; 
            //Adding comment
            return name;
        }

        public static string CreateTestMessage()
        {
            string name;
            Console.WriteLine("Hello World!\n");
            Console.WriteLine("Enter your name");
            name = "Ramesh Rangaiah1";
            //return "Hello World ."; 
            return name;
        }
    }
}
