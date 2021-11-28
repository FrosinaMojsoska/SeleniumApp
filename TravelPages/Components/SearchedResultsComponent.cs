using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPages.Components
{
    public class SearchedResultsComponent : BaseComponent
    {
        public SearchedResultsComponent(IWebDriver Driver):base(Driver)
        {

        }
        private IWebElement FromDestinationField => Driver.FindElement(By.Id("autocomplete"));
        private IWebElement ToDestinationField => Driver.FindElement(By.Id("autocomplete2"));

        public void VerifyFromDestinationSearchedValue(string ExpectedValue)
        {
            FromDestinationField.GetAttribute("value").Should().Be(ExpectedValue);
        }
        public void VerifyToDestinationSearchedValue(string ExpectedValue)
        {
            ToDestinationField.GetAttribute("value").Should().Be(ExpectedValue);
        }
        public bool IsVisible
        {
            get
            {

                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                IWebElement TotalFlightsLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("card-header")));
                return TotalFlightsLink.Displayed;

            }
        }
    }
}
