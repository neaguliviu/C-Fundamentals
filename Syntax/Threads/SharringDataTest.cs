using System;
using System.Threading;

namespace Threads
{
    class SharringDataTest
    {
        bool done;
        //also static fields are shared between threads

        public static void Execute()
        {
            SharringDataTest tt = new SharringDataTest();   // Create a common instance
            new Thread(tt.Go).Start();
            tt.Go();

            Console.ReadKey();
        }

        void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }

}
