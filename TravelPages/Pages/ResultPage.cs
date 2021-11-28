using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TravelPages.Components;

namespace TravelPages.Pages
{
    public class ResultPage : BasePage
    {
        public SearchedResultsComponent SearchedResult { get; set; }
        public ResultPage(IWebDriver driver):base(driver)
        {
            SearchedResult = new SearchedResultsComponent(driver);
        }

      
    }
}