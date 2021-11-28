using FluentAssertions;
using NUnit.Framework;
using TravelPages.Pages;
using TravelSeleniumUI.Constants;

namespace TravelSeleniumUI.Tests
{
    [TestFixture]
    public class FlightTests : FlightsBase
    {
        [Test]
        [Category("Flights")]
        public void WhenRoundTripIsSelectedVerifyThatReturnDateIsPresent()
        {
            FlightsPage flightPage = new FlightsPage(Driver);
            flightPage.SearchForm.SelectRoundTrip();
            flightPage.SearchForm.VerifyThatReturnDateDisplayed();
        }

        [Test]
        [Category("Flights")]
        public void WhenFromAndToFlightDestinationsArePopulatedVerifyThatTheSearchIsPerformedWithCorrectValues()
        {
            FlightsPage flightPage = new FlightsPage(Driver);
            flightPage.SearchForm.SelectFirstResultFromFlyingFrom(FlightPageConstants.Malpensa);
            flightPage.SearchForm.SelectFirstResultFromDestinationTo(FlightPageConstants.CharlesDeGaulle);
            flightPage.SearchForm.SearchForFlights();
            ResultPage resultPage = new ResultPage(Driver);
            resultPage.SearchedResult.IsVisible.Should().BeTrue();
            resultPage.SearchedResult.VerifyFromDestinationSearchedValue(FlightPageConstants.MalpensaAirport);
            resultPage.SearchedResult.VerifyToDestinationSearchedValue(FlightPageConstants.ParisAirport);


        }

        [Test]
        [Category("Flights")]
        public void WhenSelectingTwoAdultsAndOneChildVerifyThatTheNumberOfPassengersAreThree()
        {
            FlightsPage flightPage = new FlightsPage(Driver);
            flightPage.SearchForm.AddAdult();
            flightPage.SearchForm.AddChild();
            flightPage.SearchForm.VerifyNumberOfPassengers(FlightPageConstants.NumberOfPassengers);
        }
    }
}
