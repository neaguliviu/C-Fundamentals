using System;

namespace Exceptions
{
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string message)
            : base(message)
        {
        }
        public MyCustomException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
