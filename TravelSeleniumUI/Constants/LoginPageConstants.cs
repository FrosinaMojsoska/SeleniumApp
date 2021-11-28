using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSeleniumUI.Constants
{
    public static class LoginPageConstants
    {
        public static string Username => "user@phptravels.com";
        public static string CorrectPassword => "demouser";
        public static string IncorrectPassword => "123456";
        public static string IncorrectPasswordMessage => "Wrong credentials. try again!";
    }
}
