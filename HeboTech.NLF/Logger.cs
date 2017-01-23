using System;

namespace HeboTech.NLF
{
    public static class Logger
    {
        public static ILogger Log { get; private set; } = new VoidLogger();

        public static void SetLogger(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            Log = logger;
        }
    }
}
