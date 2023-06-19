using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TherapySelenium.Source.Drivers;

namespace TherapySelenium.Pages
{
    internal class AccountLandingPage : Driver 
    {


        public AccountLandingPage() => PageFactory.InitElements(_driver, this);


        [FindsBy(How = How.Id, Using = "FrontpageHeaderText")]
        private  IWebElement welcomeText;

        public bool WelcometextDisplayed()
        {
            return welcomeText.Displayed;
        }



    }
}
