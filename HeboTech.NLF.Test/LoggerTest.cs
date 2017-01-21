using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HeboTech.NLF.Test
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void DefaultLoggerIsNullLogger()
        {
            ILogger returnedLogger = Logger.Log;

            Assert.AreEqual(returnedLogger.GetType(), typeof(NullLogger));
        }

        [TestMethod]
        public void ChangingDefaultLogger()
        {
            ILogger logger = new Mock<ILogger>().Object;
            Logger.SetLogger(logger);

            Assert.AreEqual(logger, Logger.Log);
        }
    }
}