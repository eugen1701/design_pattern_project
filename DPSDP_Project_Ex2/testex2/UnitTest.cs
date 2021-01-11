using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace testex2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void mapReduce_wordCat4Times_expectedCorrectAns()
        {
            string text = System.IO.File.ReadAllText(@"testtext.txt");
            WordCounter reducer = new WordCounter();
            reducer.mapReduce(text);
            Assert.AreEqual(4, reducer.wordDictionary["cat"]);
        }
        [TestMethod]
        public void mapReduce_noWord_working()
        {
            string text = System.IO.File.ReadAllText(@"empty.txt");
            WordCounter reducer = new WordCounter();
            reducer.mapReduce(text);
            Assert.AreEqual(true, reducer.wordDictionary.IsEmpty);
        }
        [TestMethod]
        public void mapReduce_bigTextFile_bigOutput194Words()
        {
            string text = System.IO.File.ReadAllText(@"message.txt");
            WordCounter reducer = new WordCounter();
            reducer.mapReduce(text);
            Assert.AreEqual(194, reducer.wordDictionary.Count);
            
        }
    }
}
