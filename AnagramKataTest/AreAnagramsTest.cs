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

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void WhenWordsAreNotAnagramsReturnsFalse()
        {
            AnagramSelector selector = new AnagramSelector();

            bool result = selector.AreAnagrams("HOLA", "CARLOS");
            bool expected = false;

            Assert.AreEqual(false, result);
        }
    }
}
