using System;

namespace PureEventDemo
{
    public delegate void CatMiaoMiao(string testStr);
    internal class Cat
    {
        public event CatMiaoMiao miaomiao;
        public Action<string> ActionMiao;
        public Func<string> FuncMiao;

        public void Miao()
        {
            System.Console.WriteLine("Cat miao");
            miaomiao?.Invoke("Pig");
            ActionMiao?.Invoke("Action");
            FuncMiao?.Invoke();
        }
    }
}