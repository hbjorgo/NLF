using System;
using System.Collections.Generic;

namespace HeboTech.NLF
{
    public static class Logger
    {
        private static Dictionary<string, ILogger> loggers = new Dictionary<string, ILogger>();

        public static void RegisterLogger(string name, ILogger logger)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");
            if (logger == null)
                throw new ArgumentNullException("logger");
            loggers[name] = logger;
        }

        public static ILogger GetLogger(string name)
        {
            if (loggers.ContainsKey(name))
                return loggers[name];
            else
                return null;
        }

        public static ILogger Default { get; private set; } = new NullLogger();

        public static void SetDefaultLogger(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");
            Default = logger;
        }
    }
}
