using System;
using System.Data;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToJadenCase_PhraseIsGood()
        {
//            var training = new Training();
            string toCompare = Training.ToJadenCase("How can mirrors be real if our eyes aren't real");

            //Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
            //    "How can mirrors be real if our eyes aren't real".ToJadenCase(),
            //    "Strings didn't match.");
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", toCompare,
                "Strings didn't match.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidExpressionException))]
        public void ToJadenCase_PhraseIsEmpty_ThrowsAnException()
        {
            string toCompare = Training.ToJadenCase("");
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", toCompare,
                "Strings didn't match.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidExpressionException))]
        public void ToJadenCase_PhraseIsNull_ThrowsAnException()
        {
            string toCompare = Training.ToJadenCase(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidExpressionException))]
        public void ToJadenCase_PhraseIsWhitespace_ThrowsAnException()
        {
            string toCompare = Training.ToJadenCase(" ");
        }


        [TestMethod]
        public void NaturalNumbers_CallWithValue()
        {
            int result = Training.NaturalNumbers(10);

            Assert.AreEqual(23, result,"Sum doesn't match.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NaturalNumbers_CallWithZero_ThrowsAnException()
        {
            int result = Training.NaturalNumbers(0);
        }
    }
}
