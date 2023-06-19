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
    internal class LoginPage : Driver
    {
        public LoginPage() => PageFactory.InitElements(_driver, this);

        [FindsBy(How = How.Id, Using= "PracticeCode")]
        public IWebElement practiceCodeBox;

        [FindsBy(How = How.Id, Using = "Continue__ContinueButton")]
        public IWebElement continueBtn;

        [FindsBy(How = How.Id, Using = "Login__UsernameField")]
        public IWebElement usernameField;

        [FindsBy(How = How.Id, Using = "Login__Password")]
        public IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "Login__LogInButton")]
        private IWebElement logInBtn;

        [FindsBy(How = How.XPath, Using = "//span[text() ='The username and password you entered did not match any account.']")]
        private IWebElement invalidLogingError;
        

        public void EnterPracticeCode(string name)
        {
            practiceCodeBox.SendKeys(name);
             continueBtn.Click();
        }

        public void EnterLoginCredentials(string username, string password) {
        usernameField.SendKeys(username);
            passwordField.SendKeys(password);
        }

        public void PressLogin()
        {
            logInBtn.Click();  
        }

        public string GetInvalidText()
        {
            string invalidtext = invalidLogingError.Text;
            return invalidtext;
        }

    }
}
