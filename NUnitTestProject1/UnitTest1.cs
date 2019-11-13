using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var cap = new ChromeOptions();
            cap.AddArgument("--start-maximized");
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
        }

        [Test]
        public void Test1()
        {
            IWebElement search=driver.FindElement(By.Name("q"));
            search.SendKeys("Selenium");
            search.Submit();
        }
    }
}