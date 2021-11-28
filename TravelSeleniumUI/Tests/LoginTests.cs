using NUnit.Framework;
using TravelPages.Pages;
using FluentAssertions;
using TravelSeleniumUI.UIBase;
using TravelSeleniumUI.Constants;

namespace TravelSeleniumUI
{
    [TestFixture]
    public class LoginTests : LoginBase
    {
        [Test]
        [Category("LoginTest"), Category("UITest")]
        public void WhenUserIsNavigatedToLoginPageAndEntersValidEmailAndPasswordUserIsSucessfullyLogedin()
        {
            LoginPage loginPage= new LoginPage(Driver);
            loginPage.loginFormComponent.FillOutAndSubmitLoginForm(LoginPageConstants.Username, LoginPageConstants.CorrectPassword);
            DashboardPage dashboardPage = new DashboardPage(Driver);
            dashboardPage.VerifyPageUrl(dashboardPage.pageUrl);

        }
        [Test]
        [Category("LoginTest"), Category("UITest")]
        public void WhenUserIsNavigatedToLoginPageAndEntersInvalidPasswordCorrespondingMessageIsShown()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.loginFormComponent.FillOutAndSubmitLoginForm(LoginPageConstants.Username, LoginPageConstants.IncorrectPassword);
            loginPage.loginFormComponent.IsMessageVisible().Should().BeTrue();
            loginPage.loginFormComponent.VerifyLoginMessage(LoginPageConstants.IncorrectPasswordMessage);
           
        }

    }
}
