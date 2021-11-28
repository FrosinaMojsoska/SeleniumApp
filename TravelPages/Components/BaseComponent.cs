using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPages.Components
{
    public class BaseComponent
    {
        public IWebDriver Driver { get; set; }
        public BaseComponent(IWebDriver driver)
        {
            Driver = driver;
        }
        //public void PopulateInputField(IWebElement element, string value)
        //{
        //    element.Click();
        //    element.Clear();
        //    element.SendKeys(value);
        //}
    }
}
