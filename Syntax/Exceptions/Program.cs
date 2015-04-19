
using System;

namespace Exceptions
{
    class Program
    {
        static void CatchException(string tellMeSomething)
         {
            try
            {
                var length = tellMeSomething.Length;

                Console.WriteLine(length);

                bool isThisBoolean = Boolean.Parse(tellMeSomething);

                Console.WriteLine(isThisBoolean);
            }
            
             catch (NullReferenceException)
             {
               
                 Console.WriteLine("Oooops!!Null");
             }
            catch (FormatException)
            {
                Console.WriteLine("Oooops!!Parsing failed");
            }
             finally
             {
                 Console.WriteLine("I really don't care what you do, I always write this!!:)");
             }

         }

        private static void FileExeption()

        {
            System.IO.FileStream file = null;
            System.IO.FileInfo fileinfo = new System.IO.FileInfo("D:\\file.txt");
            try
            {
                file = fileinfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        static void Main(string[] args)
        {
            var x = Console.ReadLine();

            if (x.StartsWith("a"))
            {
                throw new MyCustomException("Well, something went wrong");
            }
            //CatchException(x);
            //CatchException(null);
            //FileExeption();
            Console.ReadLine();
        }
    }
}
