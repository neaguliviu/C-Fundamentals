using System;
using System.Threading;

namespace Threads
{
   public class JoinSleepTest
    {
        public static void Execute()
        {
            Thread t = new Thread(Go);
            t.Start();
            //t.Join();
            
            //Thread.Sleep(TimeSpan.FromSeconds(5)); // OR Thread.Sleep(5000);

            Console.WriteLine("Thread t has ended!");

            Console.ReadKey();
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
