using System;

namespace Exercises._04_Classes
{
    public class Person
    {
        public string Name { get; init; }
        public int Age { get; set; }

        public Person(string name, int age) => (Name, Age) = (name, age);

        public override string ToString() => $"{Name} ({Age})";
    }

    public static class Starter
    {
        public static void Run()
        {
            var p = new Person("Jo", 21);
            Console.WriteLine(p);
        }
    }
}
