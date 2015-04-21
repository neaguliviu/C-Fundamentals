using System;
using System.Threading;

namespace Threads
{
    public class LockerObjectTest
    {
        static bool done;
        static readonly object locker = new object();

        public static void Execute()
        {
            new Thread(Go).Start();
            Go();

            Console.ReadKey();
        }

        static void Go()
        {
            lock (locker)
            {
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
    }
}
