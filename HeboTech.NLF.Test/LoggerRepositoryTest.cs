using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace HeboTech.NLF.Test
{
    [TestClass]
    public class LoggerRepositoryTest
    {
        //Must clear all loggers after each test to avoid
        //shared glabal state between each test
        [TestCleanup]
        public void Initialize()
        {
            LoggerRepository.ClearLoggers();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingLoggerWithEmptyNameThrowsException()
        {
            LoggerRepository.AddLogger(string.Empty, new Mock<ILogger>().Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddLoggerWithEmptyLoggerThrowsException()
        {
            LoggerRepository.AddLogger("Logger", null);
        }

        [TestMethod]
        public void GetLoggerAfterAddingReturnsLogger()
        {
            ILogger logger = new Mock<ILogger>().Object;
            string loggerName = "Logger";

            LoggerRepository.AddLogger(loggerName, logger);
            ILogger returnedLogger = LoggerRepository.GetLogger(loggerName);

            Assert.AreEqual(logger, returnedLogger);
        }

        [TestMethod]
        public void GetLoggerThatIsNotAddedReturnsNull()
        {
            ILogger returnedLogger = LoggerRepository.GetLogger("Logger");

            Assert.IsNull(returnedLogger);
        }

        [TestMethod]
        public void RemovingLoggerRemovesLogger()
        {
            ILogger logger = new Mock<ILogger>().Object;
            string loggerName = "Logger";
            LoggerRepository.AddLogger(loggerName, logger);
            LoggerRepository.RemoveLogger(loggerName);
            ILogger returnedLogger = LoggerRepository.GetLogger(loggerName);

            Assert.IsNull(returnedLogger);
        }

        [TestMethod]
        public void ClearingLoggersRemovesLoggers()
        {
            ILogger logger = new Mock<ILogger>().Object;
            string loggerName = "Logger";
            LoggerRepository.AddLogger(loggerName, logger);
            LoggerRepository.ClearLoggers();
            ILogger returnedLogger = LoggerRepository.GetLogger(loggerName);

            Assert.IsNull(returnedLogger);
        }
    }
}
