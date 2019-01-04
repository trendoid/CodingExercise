using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void TestHelloWorldDefault()
        {
            var actual = new API.HelloWorld();
            Assert.AreEqual("Default Phrase", actual.ToString());
        }

        [TestMethod]
        public void TestHelloWorldPhrase()
        {
            var expected = "Hello World";
            var actual = new API.HelloWorld(expected);
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void TestHelloWorldConsolePhrase()
        {
            var expected = "Hello World Console";
            var actual = new API.HelloWorldConsole(expected);
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void TestHelloWorldDatabasePhrase()
        {
            var expected = "Hello World Database";
            var actual = new API.HelloWorldDatabase(expected);
            Assert.AreEqual(expected, actual.ToString());
        }

    }
}
