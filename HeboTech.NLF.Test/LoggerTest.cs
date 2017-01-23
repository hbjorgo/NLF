using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace HeboTech.NLF.Test
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void DefaultLoggerIsVoidLogger()
        {
            ILogger returnedLogger = Logger.Log;

            Assert.AreEqual(returnedLogger.GetType(), typeof(VoidLogger));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SettingLoggerToNullThrowsException()
        {
            Logger.SetLogger(null);
        }

        [TestMethod]
        public void SetLoggerChangesTheLogger()
        {
            ILogger logger = new Mock<ILogger>().Object;
            Logger.SetLogger(logger);

            Assert.AreEqual(logger, Logger.Log);
        }
    }
}