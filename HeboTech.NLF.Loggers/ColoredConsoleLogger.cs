using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF.Loggers
{
    public class ColoredConsoleLogger : ILogger
    {
        private ConsoleColor defaultForegroundColor;
        public LogLevel Level { get; private set; }
        public bool DisplayColors { get; private set; }

        public ColoredConsoleLogger()
            : this(LogLevel.DEBUG, false)
        {
        }

        public ColoredConsoleLogger(LogLevel level, bool displayColors)
        {
            this.Level = level;
            this.DisplayColors = displayColors;
            defaultForegroundColor = Console.ForegroundColor;
        }

        private string Format(DateTime timeStamp, string severity, string message, string memberName, string sourceFilePath, int sourceLineNumber)
        {
            return string.Format("{0} - {1} - {2} - Line {3} - {4} - {5}", timeStamp, severity, Path.GetFileName(sourceFilePath), sourceLineNumber, memberName, message);
        }

        public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Format(DateTime.Now, "DEBUG", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.DEBUG)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Format(DateTime.Now, "DEBUG", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                Console.WriteLine(ex.Message);
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Format(DateTime.Now, "ERROR", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.ERROR)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Format(DateTime.Now, "ERROR", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                Console.WriteLine(ex.Message);
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Format(DateTime.Now, "FATAL", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
                Console.Beep();
            }
        }

        public void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.FATAL)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Format(DateTime.Now, "FATAL", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                Console.WriteLine(ex.Message);
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Format(DateTime.Now, "INFO", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.INFO)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Format(DateTime.Now, "INFO", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                Console.WriteLine(ex.Message);
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Format(DateTime.Now, "WARN", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }

        public void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Level <= LogLevel.WARN)
            {
                if (DisplayColors) Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Format(DateTime.Now, "WARN", message, memberName, Path.GetFileName(sourceFilePath), sourceLineNumber));
                Console.WriteLine(ex.Message);
                if (DisplayColors) Console.ForegroundColor = defaultForegroundColor;
            }
        }
    }
}
