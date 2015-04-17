using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n---===Delegate===---\n");
            var instance = new MyClass();

            // Instantiate delegate with named methode:
            DelegateTest dt = instance.Average;


            // Invoke delegate: 
            var numbers = new List<double>() { 4, 2, 6 };
            double averageOfThree = dt(numbers);
            Console.WriteLine("The average of the following set of numbers (2, 4, 6) is: {0}", averageOfThree);
            Console.ReadKey();

            dt -= instance.Average;
            dt += MyClass.PrintFirst;
            Console.WriteLine("First element: {0}", dt(numbers));
            Console.ReadKey();


            // Instantiate delegate with anonymous methode:
            DelegateTest dt2 = delegate(List<double> input)
            {
                return input.Any() ? input.Sum() / input.Count() : 0;
            };

            double average = dt2(new List<double>() { 2, 6, 8 });
            Console.WriteLine("The average of the following set of numbers (2, 6, 8) is: {0}", average);

            /*
             * Instantiate delegate with lambda expression -> next day
             */

            Console.ReadKey();
        }
    }
}
