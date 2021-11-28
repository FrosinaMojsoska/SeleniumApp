using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPages.Components;

namespace TravelPages.Pages
{
    public class LoginPage : BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/login";

        public LoginFormComponent loginFormComponent;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Intitialize();
        }

        private void Intitialize()
        {
            loginFormComponent = new LoginFormComponent(Driver);
        }
    }
}
