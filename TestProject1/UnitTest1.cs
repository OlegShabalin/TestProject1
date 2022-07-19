usingFregWord;

newspace TestFregWord
{
    [TestClass]
public class FregWordTest
{
    [TestMethod]

    public void Test true();
   {
     Assert.IsTrue();
    }
[TestMethod]
public void Test 1 CountWords();
{
    string[] words = { "test", "test", "test", "test" };
    Assert.AreEqual(4, FregWord.UnigueWord.CountWords(words, "test"));
}

[TestMethod]
public void Test 2 CountWords()
{
    string[] words = { "test", "Test", "test", "test" };
    Assert.AreEqual(4, FregWord.UnigueWord.CountWords(words, "test"));
}

}

















