using System;

namespace ExtensionsExceptionsTest.MyExceptions
{
    public class OutOfMemoryException : Exception
    {
        public OutOfMemoryException() : base() { }
        public OutOfMemoryException(string message) : base(message) { }
        public OutOfMemoryException(string message, Exception innerException) : base(message, innerException) { }
    }
}
