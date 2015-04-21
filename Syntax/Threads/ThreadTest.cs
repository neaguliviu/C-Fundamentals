using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    public class ThreadTest
    {
        public static void Execute()
        {
            Thread t = new Thread(WriteY);          // Kick off a new thread
            t.Start();                               // running WriteY()

            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 1000; i++) Console.Write("x");

            Console.ReadKey();
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
