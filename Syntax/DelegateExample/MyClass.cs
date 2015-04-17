using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class MyClass
    {
        internal double Average(List<double> numbers)
        {
            /*
             * Check if list is empty. 
             */
            if (!numbers.Any()) return 0;

            double sum = 0;
            foreach (double nr in numbers)
            {
                sum += nr;
            }

            return sum / numbers.Count();

            /*
             * Short way:
             * return numbers.Any() ? numbers.Sum() / numbers.Count() : 0
             */
        }

        internal static double PrintFirst(List<double> numbers) 
        { 
            return numbers.Any() ? numbers.First() : 0.0; 
        } 

    }
}
