using System;

namespace ExWorkshop.Exceptions
{
    public class MyException : ArithmeticException
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, System.Exception inner) : base(message, inner) { }
    }
}