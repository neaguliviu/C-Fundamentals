namespace EnumExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    public class EnumHelper
    {
        public static string EnumTypeDescription(Enum EnumType)
        {
            FieldInfo fi = EnumType.GetType().GetField(EnumType.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return EnumType.ToString();
            }
        }

        internal IEnumerable<Int64> Fibonacci()
        {
            Int64 a = 0, b = 1;
            while (true)
            {
                yield return a;
                yield return b;
                a = a + b;
                b = a + b;
            }
        }


        /*
         * When you use the yield keyword in a statement, you indicate that the method, operator, or get accessor in which it appears is an iterator. 
         * Using yield to define an iterator removes the need for an explicit extra class (the class that holds the state for an enumeration, see IEnumerator<T> for an example)
         */
        internal IEnumerable<T> FirstTwenty<T>(IEnumerable<T> enumerable)
        {
            var count = 0;
            using (var enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext()/* && count < 20*/)
                {
                    /*
                     * Use a yield return statement to return each element one at a time.
                     */
                    yield return enumerator.Current;
                    count = count + 1;

                    /* 
                     * You can use a yield break statement to end the iteration.
                     */ 
                    if (count >= 20)
                        yield break;
                }
            }
        }

        // The other way (without yeald):
        internal IEnumerable<T> FirstTwenty_2<T>(IEnumerable<T> enumerable)
        {
            var count = 0;
            var result = new List<T>();
            using (var enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext() && count < 20)
                {
                    result.Add(enumerator.Current);
                    count = count + 1;
                }
            }

            return result;
        }


        /*
         * Exception Handling
         * A yield return statement can't be located in a try-catch block. A yield return statement can be located in the try block of a try-finally statement.
         * A yield break statement can be located in a try block or a catch block but not a finally block.
         */ 
    }
}
