using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace AutoTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughTheMenu();

            Thread.Sleep(5000);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFromThroughThePost();
            Thread.Sleep(5000);

            Driver.driver.Quit();
        }
    }
}
