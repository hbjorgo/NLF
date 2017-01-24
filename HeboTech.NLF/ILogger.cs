using System;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF
{
    /// <summary>
    /// Interface to log at various log levels.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log with the Debug level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Debug level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="ex">The exception to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Error level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Error level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="ex">The exception to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Fatal level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Fatal level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="ex">The exception to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Info level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Info level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="ex">The exception to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Warn level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
        /// <summary>
        /// Log with the Warn level.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="ex">The exception to log</param>
        /// <param name="memberName">The member name to log</param>
        /// <param name="sourceFilePath">The source file path to log</param>
        /// <param name="sourceLineNumber">The source line number to log</param>
        void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
    }
}