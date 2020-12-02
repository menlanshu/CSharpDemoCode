using System;

namespace PureEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat mycat = new Cat();
            Mouse mymouse = new Mouse();
            Bird myBird = new Bird();

            mycat.miaomiao += mymouse.MouseRun;
            mycat.miaomiao += myBird.BirdRun;
            mycat.ActionMiao += mymouse.MouseRun;
            mycat.ActionMiao += myBird.BirdRun;
            mycat.FuncMiao += mymouse.ReturnMouseRun;
            mycat.FuncMiao += myBird.ReturnBirdRun;

            mycat.miaomiao += (x => Console.WriteLine("Lambda function to use delegate"));
            mycat.ActionMiao += (x => Console.WriteLine("Lambda function to use Action"));
            mycat.FuncMiao += (() =>
            {
                Console.WriteLine("Lambda function to use Function");
                return "test";
            });


            mycat.Miao();

            Console.ReadKey();
        }
    }
}
