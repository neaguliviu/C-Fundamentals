using System;
using System.Threading.Tasks;

namespace Threads
{
    public class TasksTest
    {
        public static void Execute()
        {
            //var newTask = Task.Run(() => Go());
            var newTask = Task.Factory.StartNew(Go);
            newTask.Wait();

            Console.ReadKey();

            // Start the task executing:
            Task<string> task = Task.Factory.StartNew<string>
                (() => DownloadString("http://www.linqpad.net"));

            // We can do other work here and it will execute in parallel:
            RunSomeOtherMethod();

            // When we need the task's return value, we query its Result property:
            // If it's still executing, the current thread will now block (wait)
            // until the task finishes:
            string result = task.Result;
            
            
            Console.ReadKey();
        }

        private static void RunSomeOtherMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static string DownloadString(string uri)
        {
            using (var wc = new System.Net.WebClient())
                return wc.DownloadString(uri);
        }

        static void Go()
        {
            Console.WriteLine("Hello from the thread pool!");
        }
    }
}
