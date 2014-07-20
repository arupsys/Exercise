using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataInc.ExtensionsLib;
namespace DataInc.ExtensionsLib.Tests
{
    [TestClass()]
    public class WordUsageTests
    {
        /// <summary>
        /// If there is a comma after a word it should not be treated a 
        /// diff word
        /// </summary>
        [TestMethod()]
        public void HandlingOfPunctuationInWordUsage_Test()
        {
            var result = "This is a statement, and so is this".GetWordUsage();
            const string toCompare = "statement - 1";
            CollectionAssert.Contains(result, toCompare);
        }

        /// <summary>
        /// This is a statement, and so is this
        /// Output is in descending order
        /// this - 2
        /// is – 2
        /// a – 1
        /// statement – 1 
        /// and – 1
        /// so - 1 
        /// </summary>
        [TestMethod()]
        public void ExpectedWordUsageCount_Test()
        {
            var result = "This is a statement, and so is this".GetWordUsage();
            " ".GetWordUsage();
            var toCompare = new List<string> {"This - 2", "is - 2", "a - 1", "statement - 1", "and - 1", "so - 1"};
            CollectionAssert.AreEqual(toCompare, result);
        }

        //The method on test should return 0 elements.
        [TestMethod]
        public void ExpectedBehaviorWhenStringIsEmpty_Test()
        {
            var result = " ".GetWordUsage();
            Assert.AreEqual(0, result.Count());
        }
    }
}

