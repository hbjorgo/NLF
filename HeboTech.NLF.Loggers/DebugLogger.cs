using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF.Loggers
{
    public class DebugLogger : ILogger
    {
        public LogLevel Level { get; private set; }

        public DebugLogger()
            : this(LogLevel.DEBUG)
        {
        }

        public DebugLogger(LogLevel level)
        {
            this.Level = level;
        }

        private string Format(DateTime timeStamp, string severity, string message, string memberName, string sourceFilePath, int sourceLineNumber)
        {
            return string.Format("{0} - {1} - {2} - Line {3} - {4} - {5}", timeStamp, severity, Path.GetFileName(sourceFilePath), sourceLineNumber, memberName, message);
        }

        public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "DEBUG", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "DEBUG", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "ERROR", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "ERROR", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "FATAL", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "FATAL", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "INFO", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "INFO", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "WARN", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
            }
        }

        public void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                System.Diagnostics.Debug.WriteLine(Format(DateTime.Now, "WARN", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
