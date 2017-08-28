using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWpfApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow window = new MainWindow();
            Assert.IsNotNull(window);
            string title = window.WindowTitle();
            Assert.AreEqual(title, "TestApp");
        }
    }
}
