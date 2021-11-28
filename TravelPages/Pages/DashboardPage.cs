using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPages.Pages
{
    public class DashboardPage : BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/account/dashboard";

        public DashboardPage(IWebDriver driver):base(driver)
        {

        }

    }
}
