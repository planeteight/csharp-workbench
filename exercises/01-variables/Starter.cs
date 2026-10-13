using System;

namespace Exercises._01_Variables
{
    public static class Starter
    {
        public static void Run()
        {
            Console.WriteLine("Variables exercise:");
            // TODO: replace the values and experiment
            int a = 0;          // change to another number
            string s = "hello"; // change the text
            bool flag = true;   // flip the boolean

            Console.WriteLine($"a = {a}, s = {s}, flag = {flag}");

            // Try converting
            string numText = "123";
            if (int.TryParse(numText, out var parsed))
            {
                Console.WriteLine($"parsed: {parsed}");
            }
        }
    }
}
