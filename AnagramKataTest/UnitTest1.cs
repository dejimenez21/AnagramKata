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



            CollectionAssert.AreEquivalent(new List<string>(), result);

        }

        [TestMethod]
        public void WhenListIs1WordReturnsNolines()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "HOLA"};

            List<string> result = selector.Group(words);



            CollectionAssert.AreEquivalent(new List<string>(), result);

        }

        [TestMethod]
        public void WhenListIs2WordNotAnagramsReturnsNolines()
        {
            //Instanciando clase de selector de anagramas
            AnagramSelector selector = new AnagramSelector();
            //Creando lista vacia
            List<string> words = new List<string>() { "HOLA", "MUNDO" };

            List<string> result = selector.Group(words);



            CollectionAssert.AreEquivalent(new List<string>(), result);

        }


        
    }
}
