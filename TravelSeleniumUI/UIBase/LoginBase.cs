using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSeleniumUI.UIBase
{
    public class LoginBase:BaseTest
    {
        public string LoginPageUrl => "https://www.phptravels.net/login";
        public override void Navigate()
        {
            Driver.Navigate().GoToUrl(LoginPageUrl);
        }
    }
}
