using System;

namespace HeboTech.NLF.Loggers.TimeProvider
{
    public interface ITimeProvider
    {
        DateTime GetTime();
    }
}
