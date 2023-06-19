using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TherapySelenium.Source.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TherapySelenium.Pages
{//HomePage page object model
    internal class HomePage : Driver    {


        [FindsBy(How = How.XPath, Using = "//a[@href ='/app/login/']")]
        public IWebElement loginBtn;

        //passing Webdriver to this constructor to use the
        // using initelements method to initialzize the page elements with this pom page so that we can interact with them
        public HomePage()
        {
            PageFactory.InitElements(_driver, this);
        }

        public void ClickLoginBtn()
        {
            loginBtn.Click();          
        }

    }
}
