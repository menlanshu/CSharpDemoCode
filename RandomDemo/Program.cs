using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial Random instance
            // It's better to use the same random instance in the whole class
            // no need declare too many random items
            Random random = new Random();

            // Test for normal random
            Console.WriteLine("====Normal Random Start====");
            Enumerable.Range(1, 10).ToList().ForEach(x => Console.WriteLine($"This is {x} random value: {random.Next()}"));

            Console.WriteLine("====Normal Random End====");
            Console.WriteLine();

            Console.WriteLine("====MaxValue Random Start====");
            Enumerable.Range(1, 10).ToList().ForEach(x => Console.WriteLine($"This is {x} random value: {random.Next(10)}"));


            Console.WriteLine("====MaxValue Random End====");
            Console.WriteLine();


            Console.WriteLine("====Range Random Start====");
            Enumerable.Range(1, 10).ToList().ForEach(x => Console.WriteLine($"This is {x} random value: {random.Next(5, 10)}"));


            Console.WriteLine("====Range Random End====");
            Console.WriteLine();

            Console.WriteLine("====Double Random Start====");
            Enumerable.Range(1, 10).ToList().ForEach(x => Console.WriteLine($"This is {x} random value: {random.NextDouble()}"));


            Console.WriteLine("====Double Random End====");
            Console.WriteLine();


            Console.WriteLine("====People Order Random Start====");

            // the performance of this function is simliar with high performance order algotithm when list count is small
            // but if the count of list is very big, this method is not so efficient
            GetListOfPerson().OrderBy(x => random.Next())
                .ToList()
                .ForEach(x => Console.WriteLine($"Person order: {x.Name}"));


            Console.WriteLine("====People Order Random End====");


            Console.ReadKey();
        }

        private static List<Person> GetListOfPerson()
        {
            return new List<Person>
            {
                new Person { Name = "A"},
                new Person { Name = "B"},
                new Person { Name = "C"},
                new Person { Name = "D"},
                new Person { Name = "E"},
                new Person { Name = "F"},
            };
        }
    }
}
