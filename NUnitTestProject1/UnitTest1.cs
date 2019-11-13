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

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
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