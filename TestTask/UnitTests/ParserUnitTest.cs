using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Completor.Core.Tools;
using Completor.Core.Entities;

namespace UnitTests
{
    [TestClass]
    public class ParserUnitTest
    {
        /// <summary>
        /// Just an Example!!!
        /// </summary>
        [TestMethod]
        public void Test_Parser_Parse()
        {
            // Init
            IParser parser = new Parser();
            string[] text = new string[] { "3", "aaa 10", "aab 5", "aac 7", "0" };

            // Act
            IWordSet wordSet = parser.Parse(text);

            // Assert
            Assert.AreNotEqual(wordSet.WI, null);
            Assert.AreEqual(wordSet.WI.Length, 3);
            Assert.AreEqual(wordSet.WI[0].Value, "aaa");
            Assert.AreEqual(wordSet.WI[0].Frequency, 10);
            Assert.AreEqual(wordSet.WI[1].Value, "aab");
            Assert.AreEqual(wordSet.WI[1].Frequency, 5);
            Assert.AreEqual(wordSet.WI[2].Value, "aac");
            Assert.AreEqual(wordSet.WI[2].Frequency, 7);
            Assert.AreNotEqual(wordSet.UJ, null);
            Assert.AreEqual(wordSet.UJ.Length, 0);
        }
    }
}
