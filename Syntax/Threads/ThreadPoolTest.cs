using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadPoolTest
    {
        public static void Execute()
        {
            WaitCallback callBack;
            // Main method
            Console.WriteLine("Main thread. Is pool thread: {0}, Hash: {1}",
                     Thread.CurrentThread.IsThreadPoolThread,
                     Thread.CurrentThread.GetHashCode());

            callBack = new WaitCallback(PooledFunc);
            ThreadPool.QueueUserWorkItem(callBack,
               "Is there any screw left?");
            ThreadPool.QueueUserWorkItem(callBack,
               "How much is a 40W bulb?");
            ThreadPool.QueueUserWorkItem(callBack,
               "Decrease stock of monkey wrench");
            Console.ReadLine();
        }

        static void PooledFunc(object state)
        {
            // Pool method
            Console.WriteLine("Processing request '{0}'." +
               " Is pool thread: {1}, Hash: {2}",
               (string)state, Thread.CurrentThread.IsThreadPoolThread,
               Thread.CurrentThread.GetHashCode());

            // Simulation of processing time
            Thread.Sleep(2000);
            Console.WriteLine("Request processed");
        }
    }
}
