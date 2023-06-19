using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using TherapySelenium.Pages;

namespace TherapySelenium.Source.Drivers
{
    internal class Driver
    {
        [ThreadStatic]
        public static WebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.therapynotes.com/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }




        [TearDown]
        public void TeardownBrowser()
        {
            _driver.Quit();
        }
    }
}
