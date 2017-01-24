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
        public void PassingNullWriterInConstructorThrowsException2()
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
        public void PassingNullTimeProviderInConstructorThrowsException2()
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
        
        [TestMethod]
        public void DebugWritesDefaultFormattedMessage()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Debug("A", "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - DEBUG - C - Line 3 - B - A"), Times.Once);
        }

        [TestMethod]
        public void DebugWritesDefaultFormattedMessageAndException()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Debug("A", new Exception("ExceptionMsg"), "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - DEBUG - C - Line 3 - B - A"), Times.Once);
            writer.Verify(x => x.Write("ExceptionMsg"), Times.Once);
        }

        [TestMethod]
        public void InfoWritesDefaultFormattedMessage()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Info("A", "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - INFO - C - Line 3 - B - A"), Times.Once);
        }

        [TestMethod]
        public void InfoWritesDefaultFormattedMessageAndException()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Info("A", new Exception("ExceptionMsg"), "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - INFO - C - Line 3 - B - A"), Times.Once);
            writer.Verify(x => x.Write("ExceptionMsg"), Times.Once);
        }

        [TestMethod]
        public void WarnWritesDefaultFormattedMessage()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Warn("A", "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - WARN - C - Line 3 - B - A"), Times.Once);
        }

        [TestMethod]
        public void WarnWritesDefaultFormattedMessageAndException()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Warn("A", new Exception("ExceptionMsg"), "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - WARN - C - Line 3 - B - A"), Times.Once);
            writer.Verify(x => x.Write("ExceptionMsg"), Times.Once);
        }

        [TestMethod]
        public void ErrorWritesDefaultFormattedMessage()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Error("A", "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - ERROR - C - Line 3 - B - A"), Times.Once);
        }

        [TestMethod]
        public void ErrorWritesDefaultFormattedMessageAndException()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Error("A", new Exception("ExceptionMsg"), "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - ERROR - C - Line 3 - B - A"), Times.Once);
            writer.Verify(x => x.Write("ExceptionMsg"), Times.Once);
        }

        [TestMethod]
        public void FatalWritesDefaultFormattedMessage()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Fatal("A", "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - FATAL - C - Line 3 - B - A"), Times.Once);
        }

        [TestMethod]
        public void FatalWritesDefaultFormattedMessageAndException()
        {
            var writer = new Mock<IWriter>();
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(x => x.GetTime()).Returns(new DateTime(2016, 12, 20, 12, 0, 0));
            FormatLogger logger = new FormatLogger(writer.Object, timeProvider.Object);

            logger.Fatal("A", new Exception("ExceptionMsg"), "B", "C", 3);

            writer.Verify(x => x.Write("20.12.2016 12.00.00 - FATAL - C - Line 3 - B - A"), Times.Once);
            writer.Verify(x => x.Write("ExceptionMsg"), Times.Once);
        }
    }
}
