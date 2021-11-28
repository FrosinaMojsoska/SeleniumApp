using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPages.Pages;

namespace TravelPages.Components
{
    public class LoginFormComponent : BaseComponent
    {
        public LoginFormComponent(IWebDriver Driver) : base(Driver)
        {

        }
        private IWebElement EmailInputField => Driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        private IWebElement PasswordInputField => Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        private IWebElement LoginButton => Driver.FindElement(By.XPath("//div[@class='btn-box pt-3 pb-4']/button"));
        private IWebElement Message => Driver.FindElement(By.XPath("//div[@class='alert alert-danger failed']"));

        public void FillOutAndSubmitLoginForm(string email, string password)
        {
            FillInEmailField(email);
            FillInPasswordFiled(password);
            SubmitLoginForm();
        }
        public void FillInEmailField(string email)
        {
            //PopulateInputField(EmailInputField, email);
            EmailInputField.Click();
            EmailInputField.Clear();
            EmailInputField.SendKeys(email);
        }
        public void FillInPasswordFiled(string password)
        {
            //PopulateInputField(PasswordInputField, password);
            PasswordInputField.Click();
            PasswordInputField.Clear();
            PasswordInputField.SendKeys(password);
        }
        public void SubmitLoginForm()
        {
            LoginButton.Submit();
        }
        public bool IsMessageVisible()
        {
            return Message.Displayed;

        }
        public void VerifyLoginMessage(string ExpectedMessage)
        {
            Message.Text.Should().Contain(ExpectedMessage);
        }

    }
}
