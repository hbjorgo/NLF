using HeboTech.NLF.Loggers.TimeProvider;
using HeboTech.NLF.Loggers.Writers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace HeboTech.NLF.Loggers.Test
{
    [TestClass]
    public class FormatLoggerTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PassingNullWriterInConstructorThrowsException()
        {
            var timeProvider = new Mock<ITimeProvider>();
            new FormatLogger(null, timeProvider.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PassingNullWriterAndLogLevelInConstructorThrowsException2()
        {
            var timeProvider = new Mock<ITimeProvider>();
            new FormatLogger(LogLevel.DEBUG, null, timeProvider.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PassingNullTimeProviderInConstructorThrowsException()
        {
            var writer = new Mock<IWriter>();
            new FormatLogger(writer.Object, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PassingNullTimeProviderAndLogLevelInConstructorThrowsException2()
        {
            var writer = new Mock<IWriter>();
            new FormatLogger(LogLevel.DEBUG, writer.Object, null);
        }

        [TestMethod]
        public void DefaultLogLevelIsDebug()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            Assert.AreEqual(LogLevel.DEBUG, logger.Level);
        }

        /*
        [TestMethod]
        public void DebugWritesDefaultFormattedMessage()
        {
            string writerOutput = string.Empty;
            var writer = new Mock<IWriter>();
            FormatLogger logger = new FormatLogger(writer.Object);

            logger.Debug("A", "B", "C", 3);

            writer.Verify(x => x.Write("timestamp - DEBUG - C - Line 3 - B - A"), Times.Once);
        }
        */
    }
}
