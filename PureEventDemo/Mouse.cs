namespace PureEventDemo
{
    internal class Mouse
    {
        public void MouseRun(string scare)
        {
            System.Console.WriteLine($"{scare} mouse to run!");
        }
        public string ReturnMouseRun()
        {
            System.Console.WriteLine($"Func return mouse to run!");
            return "Miao";
        }
    }
}