using System;

namespace Exercises._03_Functions
{
    public static class Starter
    {
        public static int Add(int a, int b) => a + b;

        public static void Run()
        {
            Console.WriteLine("Functions exercise:");
            Console.WriteLine($"2 + 3 = {Add(2,3)}");
        }
    }
}
