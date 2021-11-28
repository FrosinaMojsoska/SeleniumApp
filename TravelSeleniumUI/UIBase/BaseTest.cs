using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace TravelSeleniumUI
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }
        public string TravelPageUrl => "https://www.phptravels.net/login";

        [SetUp]
        public virtual void BeforeEachTest()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Navigate();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Driver.Close();
            Driver.Quit();
        }
        public virtual void Navigate()
        {
            Driver.Navigate().GoToUrl(TravelPageUrl);

        }
    }
}