using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Ramesh Rangaiah21 World", "Hello " + Program.CreateTestMessage() + " World");
              //AddingComment from IDE
              //Update Comment from Others /GIT
        }
    }
}
