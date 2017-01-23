using HeboTech.NLF.Loggers.TimeProvider;
using HeboTech.NLF.Loggers.Writers;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF.Loggers
{
    public class FormatLogger : ILogger
    {
        public LogLevel Level { get; private set; }
        private IWriter writer;
        private ITimeProvider timeProvider;

        public FormatLogger(IWriter writer, ITimeProvider timeProvider)
            : this(LogLevel.DEBUG, writer, timeProvider)
        {
        }

        public FormatLogger(LogLevel level, IWriter writer, ITimeProvider timeProvider)
        {
            this.Level = level;
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            this.writer = writer;
            if (timeProvider == null)
                throw new ArgumentNullException(nameof(TimeProvider));
            this.timeProvider = timeProvider;
        }

        protected virtual string Format(DateTime timeStamp, string severity, string message, string memberName, string sourceFilePath, int sourceLineNumber)
        {
            return string.Format("{0} - {1} - {2} - Line {3} - {4} - {5}", timeStamp, severity, Path.GetFileName(sourceFilePath), sourceLineNumber, memberName, message);
        }

        public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                writer.Write(Format(timeProvider.GetTime(), "DEBUG", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                writer.Write(Format(timeProvider.GetTime(), "DEBUG", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                writer.Write(ex.Message);
            }
        }

        public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                writer.Write(Format(timeProvider.GetTime(), "ERROR", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                writer.Write(Format(timeProvider.GetTime(), "ERROR", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                writer.Write(ex.Message);
            }
        }

        public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                writer.Write(Format(timeProvider.GetTime(), "FATAL", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                writer.Write(Format(timeProvider.GetTime(), "FATAL", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                writer.Write(ex.Message);
            }
        }

        public void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                writer.Write(Format(timeProvider.GetTime(), "INFO", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                writer.Write(Format(timeProvider.GetTime(), "INFO", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                writer.Write(ex.Message);
            }
        }

        public void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                writer.Write(Format(timeProvider.GetTime(), "WARN", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                writer.Write(Format(timeProvider.GetTime(), "WARN", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                writer.Write(ex.Message);
            }
        }
    }
}
