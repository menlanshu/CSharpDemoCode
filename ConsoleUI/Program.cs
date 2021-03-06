﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Eventsdemo;
using ConsoleUI.InterfaceDemo;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Csharp8Demo.CsharpDemoClass.MainTest();
            //Async_Await_Demo.Async_Await_DemoClass.MainTest();
            //DelegatesDemo.DelegatesDemoClass.MainTest();
            //EventsDemoClass.MainTest();
            //GenericsDemo.GenericDemoClass.MainTest();

        }

        // A test method for access modifier verification
        private static void ModifierAccessTest()
        {
            AccessDemo demo = new AccessDemo();

            // We can call public Demo from the external project
            demo.PublicDemo();


            BadClass badClass = new BadClass();
            //badClass.creditCardNumber
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello User");
        }

    }
}
