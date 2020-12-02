namespace PureEventDemo
{
    internal class Bird
    {
        public void BirdRun(string scare)
        {
            System.Console.WriteLine($"{scare} bird to run!");
        }
        public string ReturnBirdRun()
        {
            System.Console.WriteLine($"Func return bird to run!");
            return "Miao";
        }
    }
}