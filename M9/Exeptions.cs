using System;

namespace M9_task1
{   /// <summary>
    /// Собственный класс исключения
    /// </summary>
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }

}
