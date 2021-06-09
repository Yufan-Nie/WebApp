using System;

namespace Contest
{
    public delegate void GreetingDelegate(string name);

    // 新建的GreetingManager类
    public class GreetingManager
    {
        //在GreetingManager类的内部声明delegate变量
        public GreetingDelegate greet_delegate;

        public void GreetPeople(string name)
        {
            if (greet_delegate != null)
            {
                greet_delegate(name);
            }
        }
    }
    class Program
    {
        private static void GreetingEnglish(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        private static void GreetingChinese(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
        static void Main(string[] args)
        {
            GreetingManager gm = new GreetingManager();
            // 首先对 “小明” 使用同时早上好和Morning进行问候
            // 然后对 “Marry” 只使用 Morning 问候

            gm.greet_delegate = new GreetingDelegate(GreetingEnglish);
            gm.greet_delegate += GreetingChinese;
            gm.GreetPeople("小明");
            gm.greet_delegate = new GreetingDelegate(GreetingEnglish);
            gm.GreetPeople("Marry");
            Console.ReadKey();
        }
    }
}
