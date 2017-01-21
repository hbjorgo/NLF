using System;

namespace HeboTech.NLF
{
    public static class Logger
    {
        public static ILogger Log { get; private set; } = new NullLogger();

        public static void SetLogger(ILogger logger)
        {
            Log = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
