using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumMixupTest.Pages
{
    public class MainPage
    {
        private IWebDriver _webDriver;
        public MainPage(IWebDriver webDriver) => this._webDriver = webDriver;
        
        public void ClickOnLoginLink()
        {
            //GET ALL <a> TAGS
            var linkElements = this._webDriver.FindElements(By.TagName("a"));

            //NEEDED TO FILTER OUT <a> TAGS WITH HREF
            var linkElementsWithHref = linkElements.Where(x => x.GetAttribute("href") != null);

            //GET LOGIN ELEMENT
            var loginElement = linkElementsWithHref.Where(x => x.GetAttribute("href").Contains("LOGIN.aspx")).FirstOrDefault();

            if (loginElement == null)
                throw new NullReferenceException("Login Element could not be found!");

            loginElement.Click();
        }
    }
}
