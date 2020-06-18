using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Scraping_Test.Pages
{
    public class LoginPage
    {
        private IWebDriver _webDriver;

        private string _username = "MyUsername";
        private string _password = "MyPassword";

        private string _usernameIdTag = "ctl00_ContentPlaceHolder1_loginControl_UserName";
        private string _passwordIdTag = "ctl00_ContentPlaceHolder1_loginControl_Password";
        private string _loginButtonIdTag = "ctl00_ContentPlaceHolder1_loginControl_LoginButton";

        public LoginPage(IWebDriver webDriver) => this._webDriver = webDriver;

        public void FillInCredentialsAndLogin()
        {
            FillInUsername();
            FillInPassword();
            ClickOnLogin();
        }

        private void FillInUsername()
        {
            var input = this._webDriver.FindElement(By.Id(_usernameIdTag));
            input.SendKeys(_username);
        }

        private void FillInPassword()
        {
            var input = this._webDriver.FindElement(By.Id(_passwordIdTag));
            input.SendKeys(_password);
        }

        private void ClickOnLogin()
        {
            var button = this._webDriver.FindElement(By.Id(_loginButtonIdTag));
            button.Click();
        }
    }
}
