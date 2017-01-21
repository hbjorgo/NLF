using System;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF.Loggers
{
    public class MultiLogger : ILogger
    {
        private ILogger[] loggers;

        public MultiLogger(params ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Debug(message, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Debug(message, ex, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Error(message, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Error(message, ex, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Fatal(message, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Fatal(message, ex, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Info(message, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Info(message, ex, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Warn(message, memberName, sourceFilePath, sourceLineNumber);
        }

        public void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            foreach (ILogger logger in loggers)
                logger.Warn(message, ex, memberName, sourceFilePath, sourceLineNumber);
        }
    }
}
