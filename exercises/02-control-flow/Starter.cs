using System;

namespace Exercises._02_ControlFlow
{
    public static class Starter
    {
        public static void Run()
        {
            Console.WriteLine("Control flow exercise:");
            // TODO: Implement sample branching and loops
            int x = 5;
            if (x > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("non-positive");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
