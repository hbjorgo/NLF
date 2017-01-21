using System;
using System.Collections.Generic;

namespace HeboTech.NLF
{
    public static class LoggerRepository
    {
        private static Dictionary<string, ILogger> loggers = new Dictionary<string, ILogger>();

        public static void AddLogger(string name, ILogger logger)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            loggers[name] = logger;
        }

        public static void RemoveLogger(string name)
        {
            if (loggers.ContainsKey(name))
                loggers.Remove(name);
        }

        public static ILogger GetLogger(string name)
        {
            if (loggers.ContainsKey(name))
                return loggers[name];
            else
                return null;
        }

        public static void ClearLoggers()
        {
            loggers.Clear();
        }
    }
}
