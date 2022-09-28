using System;

namespace Practica.EF.Commons
{
    public class InvalidDataException : Exception
    { 
        public InvalidDataException() : base() { }
        public InvalidDataException(string message) : base(message) { }
        public InvalidDataException(string message, Exception innerException) : base(message, innerException) { }
    }
}
