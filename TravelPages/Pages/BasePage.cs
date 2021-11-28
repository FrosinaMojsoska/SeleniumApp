using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPages.Pages
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public virtual string pageUrl { get; set; }

        public BasePage (IWebDriver driver)
        {
            Driver = driver;
        }
        public void VerifyPageUrl(string ExpectedUrl)
        {
            Driver.Url.Should().Be(ExpectedUrl);
        }
    }
}
