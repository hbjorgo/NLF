using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeboTech.NLF.Test
{
    [TestClass]
    public class LogLevelTest
    {
        [TestMethod]
        public void LogLevelDebugIs0()
        {
            Assert.AreEqual(0, (int)LogLevel.DEBUG);
        }

        [TestMethod]
        public void LogLevelInfoIs1()
        {
            Assert.AreEqual(1, (int)LogLevel.INFO);
        }

        [TestMethod]
        public void LogLevelWarnIs2()
        {
            Assert.AreEqual(2, (int)LogLevel.WARN);
        }

        [TestMethod]
        public void LogLevelErrorIs3()
        {
            Assert.AreEqual(3, (int)LogLevel.ERROR);
        }

        [TestMethod]
        public void LogLevelFatalIs4()
        {
            Assert.AreEqual(4, (int)LogLevel.FATAL);
        }
    }
}
