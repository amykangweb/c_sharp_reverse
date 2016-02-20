using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Three ways to return reversed string.

            // Print out string in reverse order.
            string HelloWorld = "Hello World!";

            for(var i = HelloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(HelloWorld[i]);
            }

            // Save reversed string to variable and print out.
            string ReversedString = "";

            for(var i = HelloWorld.Length - 1; i >= 0; i--)
            {
                ReversedString = ReversedString + HelloWorld[i];
            }
            Console.WriteLine(ReversedString);

            // Convert string to array then reverse and print out.
            char[] ReversedArray = HelloWorld.ToCharArray();
            Array.Reverse(ReversedArray);
            Console.WriteLine(string.Join("", ReversedArray));
            Console.Read();
        }
    }
}
