using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises._05_Collections
{
    public static class Starter
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Evens: " + string.Join(", ", evens));
        }
    }
}
