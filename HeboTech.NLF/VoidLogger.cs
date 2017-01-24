using System;
using System.Runtime.CompilerServices;

namespace HeboTech.NLF
{
    /// <summary>
    /// An empty Logger that doesn't do anything. This can be used to always have a logger assigned to avoid checking for null.
    /// </summary>
    public class VoidLogger : ILogger
    {
        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Debug(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Error(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Fatal(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Info(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Info(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Warn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }

        /// <summary>
        /// Empty method that doesn't do anything.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Warn(string message, Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            //Don't do anything here.
        }
    }
}
