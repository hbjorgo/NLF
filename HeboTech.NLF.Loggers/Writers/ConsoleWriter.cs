using System;

namespace HeboTech.NLF.Loggers.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
