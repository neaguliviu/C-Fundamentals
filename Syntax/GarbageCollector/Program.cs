using System;
using System.Globalization;
using System.IO;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[] buffer = new Char[50];
            using (StreamReader s = new StreamReader(@"..\..\File1.txt"))
            {
                int charsRead = 0;
                while (s.Peek() != -1)
                {
                    charsRead = s.Read(buffer, 0, buffer.Length);
                }
                Console.WriteLine(buffer);
                s.Close();
            }
            Console.ReadKey();


            //OR


            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"..\..\File1.txt");
                String contents = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine("The file has {0} text elements.",
                                  new StringInfo(contents).LengthInTextElements);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error has occurred.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("There is insufficient memory to read the file.");
            }
            finally
            {
                if (sr != null) sr.Dispose();
                Console.ReadKey();
            }
        }

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("GC Maximum Generations:" + GC.MaxGeneration);

        //        Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        //        BaseGC oBaseGC = new BaseGC();
        //        oBaseGC.Display();
        //        Console.WriteLine("BaseGC Generation is :" + GC.GetGeneration(oBaseGC));
        //        Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        //    }
        //    catch (Exception oEx)
        //    {
        //        Console.WriteLine("Error:" + oEx.Message);
        //    }
        //    finally
        //    {
        //        Console.ReadKey();
        //    }
        //}
    }

    class BaseGC
    {
        private string fieldExample = "Ana Maria";
        private int[] ceva = new int[10];
        public void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                ceva[i] = 24;
            }
        }
    }
}
