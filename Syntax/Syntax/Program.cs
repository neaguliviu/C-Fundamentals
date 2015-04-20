using System;

namespace Syntax1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration statement. 
            int counter;

            // Assignment statement.
            counter = 1;

            // Error! This is an expression, not an expression statement. 
            // counter + 1;  

            const double pi = 3.14159; // Declare and initialize  constant.    
            //pi = 23; Error! The left-hand side of an assignment must be a variable, property or indexer
            Console.WriteLine("This is the value of pi: {0}..", pi);
            // Declaration statements with initializers are functionally 
            // equivalent to  declaration statement followed by assignment statement:          
            int[] fibArray = { 0, 1, 1, 2, 3, 5, 8, 13 }; // Declare and initialize an array. 

            // foreach statement block that contains multiple statements. 
            foreach (int number in fibArray)
            {
                // Expression statement (method invocation). A single-line 
                // statement can span multiple text lines because line breaks 
                // are treated as white space, which is ignored by the compiler.
                Console.WriteLine("#{0} from fibonacci sequence is: {1}",
                                        counter, number);

                // Expression statement (postfix increment).
                counter++;

            } // End of foreach statement block
            Console.ReadKey();


            //Expressions
            var twoNumbersAreEqual = fibArray[1] == fibArray[2];
            if (twoNumbersAreEqual)
                Console.WriteLine("#1 and #2 from fibonacci sequente are equal");
            else
                Console.WriteLine("#1 and #2 from fibonacci sequente are not equal");
            //versus
             twoNumbersAreEqual = fibArray[2] == fibArray[3];
             //ternary operator: <test> ? <resultIfTrue>: <resultIfFalse>
            Console.WriteLine(twoNumbersAreEqual
                                  ? "#2 and #3 from fibonacci sequente are equal"
                                  : "#2 and #3 from fibonacci sequente are not equal");
            Console.ReadKey();

            //null-coalescing operator ??

            //primitive types
           
        }
    }
}
