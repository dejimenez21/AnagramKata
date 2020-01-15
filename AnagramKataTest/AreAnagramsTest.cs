using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramKata;
using System.Collections.Generic;

namespace AnagramKataTest
{
    [TestClass]
    public class AreAnagramsTest
    {
        [TestMethod]
        public void WhenWordsAreTheSameReturnsFalse()
        {
            AnagramSelector selector = new AnagramSelector();

            bool result = selector.AreAnagrams("HOLA", "HOLA");
            bool expected = false;

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void WhenWordsAreNotAnagramsReturnsFalse()
        {
            AnagramSelector selector = new AnagramSelector();

            bool result = selector.AreAnagrams("HOLA", "CARLOS");
            bool expected = false;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When4CharsWordsAreAnagramsReturnsTrue()
        {
            AnagramSelector selector = new AnagramSelector();

            bool result = selector.AreAnagrams("SOPA", "PASO");
            bool expected = true;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When6CharsWordsAreAnagramsReturnsTrue()
        {
            AnagramSelector selector = new AnagramSelector();

            bool result = selector.AreAnagrams("FRESHER", "REFRESH");
            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}
