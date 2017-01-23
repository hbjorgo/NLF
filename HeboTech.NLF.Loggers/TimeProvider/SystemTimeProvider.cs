using System;

namespace HeboTech.NLF.Loggers.TimeProvider
{
    public class SystemTimeProvider : ITimeProvider
    {
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
