using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPages.Components;

namespace TravelPages.Pages
{
    public class FlightsPage:BasePage
    {
        public FlightsSearchFormComponent SearchForm { get; set; }
        public FlightsPage(IWebDriver driver): base(driver)
        {
            SearchForm = new FlightsSearchFormComponent(driver);
        }

    }
}
