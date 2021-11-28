using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSeleniumUI
{
    public class FlightsBase : BaseTest
    {
        public string FlightsPageUrl => "https://www.phptravels.net/flights";
        public override void Navigate()
        {
            Driver.Navigate().GoToUrl(FlightsPageUrl);
        }
    }
}
