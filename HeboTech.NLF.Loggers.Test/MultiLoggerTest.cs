using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace HeboTech.NLF.Loggers.Test
{
    [TestClass]
    public class MultiLoggerTest
    {
        /*
         * Debug
         */

        [TestMethod]
        public void DebugWithoutExceptionParamCallsDebugOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Debug(string.Empty, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Debug(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Debug(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void DebugWithExceptionParamCallsDebugOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            var exception = new Mock<Exception>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Debug(string.Empty, exception.Object, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Debug(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Debug(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        /*
         * Info
         */

        [TestMethod]
        public void InfoWithoutExceptionParamCallsInfoOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Info(string.Empty, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Info(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Info(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void InfoWithExceptionParamCallsInfoOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            var exception = new Mock<Exception>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Info(string.Empty, exception.Object, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Info(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Info(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        /*
         * Warn
         */

        [TestMethod]
        public void WarnWithoutExceptionParamCallsWarnOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Warn(string.Empty, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Warn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Warn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void WarnWithExceptionParamCallsWarnOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            var exception = new Mock<Exception>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Warn(string.Empty, exception.Object, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Warn(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Warn(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        /*
         * Error
         */

        [TestMethod]
        public void ErrorWithoutExceptionParamCallsErrorOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Error(string.Empty, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Error(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Error(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void ErrorWithExceptionParamCallsErrorOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            var exception = new Mock<Exception>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Error(string.Empty, exception.Object, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Error(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Error(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        /*
         * Fatal
         */

        [TestMethod]
        public void FatalWithoutExceptionParamCallsFatalOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Fatal(string.Empty, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Fatal(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Fatal(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void FatalWithExceptionParamCallsFatalOnAllLoggers()
        {
            var loggerA = new Mock<ILogger>();
            var loggerB = new Mock<ILogger>();
            var exception = new Mock<Exception>();
            MultiLogger tada = new MultiLogger(loggerA.Object, loggerB.Object);

            tada.Fatal(string.Empty, exception.Object, string.Empty, string.Empty, 0);

            loggerA.Verify(x => x.Fatal(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            loggerB.Verify(x => x.Fatal(It.IsAny<string>(), It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }
    }
}
