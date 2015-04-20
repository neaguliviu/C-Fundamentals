using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main()
        {
            new Thread(Go).Start();      // Call Go() on a new thread
            Go();
            Console.ReadKey(); // Call Go() on the main thread
        }

        static void Go()
        {
            // Declare and use a local variable - 'cycles'
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('?');
        }
    }
}
