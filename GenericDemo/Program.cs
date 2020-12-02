using GenericDemo.Models;
using GenericDemo.ProcessorClass;
using System;
using System.Collections.Generic;

namespace GenericDemo
{
    // what generic are?
    // what make genreic so powerful?
    class Program
    {
        // List Example
        // do not use array list, it's deperated

        // Demonstrate people/logs file
        // initial file
        // save to file
        // log , error, message, datatime
        // limit generic type with where

        static void Main(string[] args)
        {
            //// Initial data
            //List<Person> people = new List<Person>();
            //List<LogEntry> logs = new List<LogEntry>();

            //// mock data get
            //PopulateLists(people, logs);

            //// file  path assign
            //string peopleFile = @"testpath";

            //// save person list to file
            //FileProcessor.SaveToFile(people, peopleFile);

            //// read out person from file for test
            //var testPeople = FileProcessor.ReadFromFile<Person>(peopleFile);

            TestGenericClass testGenericClass = new TestGenericClass { Id = 10000 };
            TestGeneric(testGenericClass);
            TestTwoTypeGeneric(testGenericClass, testGenericClass);

            Console.WriteLine($"Class plus class {testGenericClass + testGenericClass}");

            Console.ReadKey();
        }

        private static void TestGeneric<T>(T input) where T : class, TestGenericInterface
        {
            Console.WriteLine($"Current intance Id is {input.Id}");
        }
        private static void TestTwoTypeGeneric<T, U>(T inputT, U inputU) where T : class, TestGenericInterface where U: class
        {
            Console.WriteLine($"Current T intance Id is {inputT.Id}, U instance id is {inputU}");
        }

        interface TestGenericInterface
        {
            public int Id { get; set; }
        }

        class TestGenericClass : TestGenericInterface
        {
            public int Id { get; set; }

            public override string ToString()
            {
                return $"This is a TestGenericClass with id as {Id}";
            }

            public static TestGenericClass operator+(TestGenericClass x, TestGenericClass y)
            {
                TestGenericClass testOperator = new TestGenericClass();

                testOperator.Id = x.Id + y.Id;

                return testOperator;
            }

            public static TestGenericClass operator- (TestGenericClass x, TestGenericClass y)
            {
                TestGenericClass testOperator = new TestGenericClass();

                testOperator.Id = x.Id + y.Id;

                return testOperator;
            }

            public static TestGenericClass operator/ (TestGenericClass x, TestGenericClass y)
            {
                TestGenericClass testOperator = new TestGenericClass();

                testOperator.Id = x.Id + y.Id;

                return testOperator;
            }

            public static TestGenericClass operator*(TestGenericClass x, TestGenericClass y)
            {
                TestGenericClass testOperator = new TestGenericClass();

                testOperator.Id = x.Id + y.Id;

                return testOperator;
            }

            // >= and <= should exist in class at the same time
            public static bool operator>= (TestGenericClass x, TestGenericClass y)
            {
                TestGenericClass testOperator = new TestGenericClass();

                testOperator.Id = x.Id + y.Id;

                return false;
            }
            public static bool operator<=(TestGenericClass x, TestGenericClass y)
            {
                TestGenericClass testOperator = new TestGenericClass();

                testOperator.Id = x.Id + y.Id;

                return false;
            }
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            // if you use new, then list outside of the function will not be able to get the list values
            people.Add(new Person { FirstName = "Fu", LastName = "Long", IsAlive = true });
            people.Add(new Person {FirstName = "Kuang", LastName = "Dali", IsAlive = true});

            //people = new List<Person>
            //{
            //    new Person {FirstName = "Fu", LastName = "Long", IsAlive = true},
            //    new Person {FirstName = "Kuang", LastName = "Dali", IsAlive = true},
            //};

            logs = new List<LogEntry>
            {
                new LogEntry {ErrorCode =1, ErrorMessage = "Message 1"},
                new LogEntry {ErrorCode =2, ErrorMessage = "Message 2"},
            };
        }
    }
}
