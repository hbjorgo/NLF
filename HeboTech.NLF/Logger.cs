using System;

namespace HeboTech.NLF
{
    /// <summary>
    /// This is the entry point where one can get and set the current logger.
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Returns the current logger.
        /// </summary>
        public static ILogger Log { get; private set; } = new VoidLogger();

        /// <summary>
        /// Sets the current logger.
        /// </summary>
        /// <param name="logger">The new logger to set.</param>
        public static void SetLogger(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            Log = logger;
        }
    }
}
