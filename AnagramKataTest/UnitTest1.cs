using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramKata;
using System.Collections.Generic;

namespace AnagramKataTest
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void WhenListIsEmptyReturnsNoLines()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>();

            List<string> result = selector.Group(words);



            CollectionAssert.AreEqual(new List<string>(), result);

        }

        [TestMethod]
        public void WhenListIs1WordReturnsNolines()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "HOLA"};

            List<string> result = selector.Group(words);



            CollectionAssert.AreEqual(new List<string>(), result);

        }

        [TestMethod]
        public void WhenListIs2WordNotAnagramsReturnsNolines()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "HOLA", "UNDO" };

            List<string> result = selector.Group(words);



            CollectionAssert.AreEqual(new List<string>(), result);

        }

        [TestMethod]
        public void WhenIs2AnagramsReturnsALineWith2Words()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "SACO", "CASO" };

            List<string> result = selector.Group(words);
            List<string> expected = new List<string>() { "SACO CASO " };

            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]
        public void WhenIs4WordsWith2SetsOfAnagramsReturns2LineWith2Words()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "SACO", "CASO", "FRESHER", "REFRESH" };

            List<string> result = selector.Group(words);
            List<string> expected = new List<string>() { "SACO CASO ", "FRESHER REFRESH " };


            CollectionAssert.AreEqual(expected, result);

        }


        [TestMethod]
        public void WhenIs4WordsWith1SetsOf3AnagramsReturns1LineWith3Words()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "SACO", "SHERFER", "FRESHER", "REFRESH" };

            List<string> result = selector.Group(words);
            List<string> expected = new List<string>() { "SHERFER FRESHER REFRESH " };

            
            CollectionAssert.AreEqual(expected, result);

        }
    }
}
