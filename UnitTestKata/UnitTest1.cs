using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestKata
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ToJadenCaseTests()
        {
                Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                    "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                    "Strings didn't match.");
        }
    }
}
