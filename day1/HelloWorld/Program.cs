using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name:");
            var name=Console.ReadLine();
            var date=DateTime.Now;
            System.Console.WriteLine("Hello {0} on Date {1} at time {2}",name,date.ToShortDateString(),date.ToShortTimeString());
            System.Console.WriteLine("Press any key to exit!!");
            Console.ReadKey(true);
        }
    }
}
