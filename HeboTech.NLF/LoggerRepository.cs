using System;
using System.Collections.Generic;

namespace HeboTech.NLF
{
    /// <summary>
    /// This class lets one get and set different loggers associated with a unique name.
    /// </summary>
    public static class LoggerRepository
    {
        private static Dictionary<string, ILogger> loggers = new Dictionary<string, ILogger>();

        /// <summary>
        /// Add a new logger
        /// </summary>
        /// <param name="name">A unique name</param>
        /// <param name="logger">The logger to set</param>
        public static void AddLogger(string name, ILogger logger)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            loggers[name] = logger;
        }

        /// <summary>
        /// Removes the logger associated with the specified name if it exists.
        /// </summary>
        /// <param name="name">The name of the logger to remove</param>
        public static void RemoveLogger(string name)
        {
            if (loggers.ContainsKey(name))
                loggers.Remove(name);
        }

        /// <summary>
        /// Returns the logger with the specified name if it exists, null otherwise.
        /// </summary>
        /// <param name="name">The name of the logger to return</param>
        /// <returns>The specified logger if it exists, null otherwise</returns>
        public static ILogger GetLogger(string name)
        {
            if (loggers.ContainsKey(name))
                return loggers[name];
            else
                return null;
        }

        /// <summary>
        /// Clears the collection of loggers.
        /// </summary>
        public static void ClearLoggers()
        {
            loggers.Clear();
        }
    }
}
