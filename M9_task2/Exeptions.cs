using System;

namespace M9_task2
{
    /// <summary>
    /// Мой класс исключения
    /// </summary>
    class MyClassException : Exception
    {
        public MyClassException()
        { }

        public MyClassException(string message)
            : base(message)
        { }

    }
}
