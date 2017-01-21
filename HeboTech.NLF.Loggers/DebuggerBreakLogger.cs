using System;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF.Loggers
{
    public class DebuggerBreakLogger : ILogger
    {
        public LogLevel Level { get; private set; }

        public DebuggerBreakLogger()
            : this(LogLevel.DEBUG)
        {
        }

        public DebuggerBreakLogger(LogLevel level)
        {
            this.Level = level;
        }

        public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
