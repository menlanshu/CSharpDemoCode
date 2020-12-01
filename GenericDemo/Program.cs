﻿using GenericDemo.Models;
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
            // Initial data
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            // mock data get
            PopulateLists(people, logs);

            // file  path assign
            string peopleFile = @"testpath";

            // save person list to file
            FileProcessor.SaveToFile(people, peopleFile);

            // read out person from file for test
            var testPeople = FileProcessor.ReadFromFile<Person>(peopleFile);
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
