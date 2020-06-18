using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Selenium_Scraping_Test.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Scraping_Test
{
    class Program
    {
        private static IWebDriver _driver;
        static void Main(string[] args)
        {
            //SETUP DRIVER
            _driver = new FirefoxDriver();
            _driver.Url = @"https://www.ishopmixup.com/ishop/tiendas.aspx";

            //SETUP PAGES
            var mainPage = new MainPage(_driver);
            var loginPage = new LoginPage(_driver);

            //START PROCESS
            mainPage.ClickOnLoginLink();
            loginPage.FillInCredentialsAndLogin();

            Console.ReadLine();
        }
    }
}
