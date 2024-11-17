using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MiniTask;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCanFormat_ValidLength_ReturnsTrue()
        {
            bool result = FormatTextProgramm.CanFormat(10, "Hello");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCanFormat_InvalidLength_ReturnsFalse()
        {
            bool result = FormatTextProgramm.CanFormat(5, "Hello, World!");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFormatLine_CorrectlyFormatsLine()
        {
            string result = FormatTextProgramm.FormatLine(10, "Hi");
            Assert.AreEqual("   Hi    ", result); 
        }

        [TestMethod]
        public void TestFormatLine_LongLine_ReturnsEmpty()
        {
            string result = FormatTextProgramm.FormatLine(10, "Hello, World!");
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void TestFormatLine_OnlySpaces_ReturnsFormatted()
        {
            string result = FormatTextProgramm.FormatLine(6, "Hi");
            Assert.AreEqual(" Hi   ", result); 
        }
    }
}
