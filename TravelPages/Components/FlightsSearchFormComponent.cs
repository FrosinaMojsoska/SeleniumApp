using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelPages.Components
{
    public class FlightsSearchFormComponent : BaseComponent
    {
        public FlightsSearchFormComponent (IWebDriver driver) : base(driver)
        {

        }

        private IWebElement RoundTripRadioBtn => Driver.FindElement(By.Id("round-trip"));
        private IWebElement FromDestinationField => Driver.FindElement(By.Id("autocomplete"));
        private IWebElement FirstFlightFromDropDown => Driver.FindElement(By.XPath("//div[@data-index='0']"));
        private IWebElement ToDestinationField => Driver.FindElement(By.Id("autocomplete2"));
        private IWebElement PassengerBtn => Driver.FindElement(By.XPath("//a[@class='dropdown-toggle dropdown-btn waves-effect']"));
        private IWebElement AdultPlusBtn => Driver.FindElement(By.XPath("//input[@id='fadults']/following-sibling::div"));
        private IWebElement ChildPlusBtn => Driver.FindElement(By.XPath("//input[@id='fchilds']/following-sibling::div"));
        private IWebElement NumberOfPassengers => Driver.FindElement(By.XPath("//span[@class='guest_flights d-block text-center']"));
        private IWebElement SearchBtn => Driver.FindElement(By.Id("flights-search"));
        private IWebElement ReturnDate => Driver.FindElement(By.Id("return"));

        public void SelectRoundTrip()
        {
            RoundTripRadioBtn.Click();
        }

        public void SelectFirstResultFromFlyingFrom(string destination)
        {
            FromDestinationField.Click();
            FromDestinationField.SendKeys(destination);
            FirstFlightFromDropDown.Click();
        }
        public void SelectFirstResultFromDestinationTo(string destinationTo)
        {
            ToDestinationField.Click();
            ToDestinationField.SendKeys(destinationTo);
            FirstFlightFromDropDown.Click();
        }
        public void SearchForFlights()
        {
            SearchBtn.Click();
        }
        public void AddAdult()
        {
            if(!AdultPlusBtn.Displayed)
                PassengerBtn.Click();
            AdultPlusBtn.Click();
        }
        public void AddChild()
        {
            if (!ChildPlusBtn.Displayed)
                PassengerBtn.Click();
            ChildPlusBtn.Click();
        }
        public void VerifyThatReturnDateDisplayed()
        {
            ReturnDate.Displayed.Should().BeTrue();
        }
        public void VerifyNumberOfPassengers(int expectedNumberOfPassengers)
        {
            NumberOfPassengers.Text.Should().Be(expectedNumberOfPassengers.ToString());
        }
    }
}
