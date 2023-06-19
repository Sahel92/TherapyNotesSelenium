using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TherapySelenium.Pages;
using TherapySelenium.Source.Drivers;
using WebDriverManager.DriverConfigs.Impl;

namespace TherapySelenium.Test
{
    //must use this attribute at the class level to allow parallel testing
    [Parallelizable(ParallelScope.All)]

    internal class LoginPageTests : Driver
    {
        

        [Test]
        public void PerformLogin()
        {
            HomePage hp = new HomePage();
            LoginPage lp = new LoginPage();
            AccountLandingPage alp = new AccountLandingPage();
          hp.ClickLoginBtn();
            lp.EnterPracticeCode("SahelM");
            lp.EnterLoginCredentials("johncena206", "Wrestling206$");
            lp.PressLogin();
            Console.WriteLine("User has logged in successfully");
        }

        [Test]
        public void InvalidUsernameLogin()
        {
            HomePage hp = new HomePage();
            LoginPage lp = new LoginPage();
            AccountLandingPage alp = new AccountLandingPage();
            hp.ClickLoginBtn();
            lp.EnterPracticeCode("SahelM");            
            lp.EnterLoginCredentials("cena206", "Wrestling206$");
            lp.PressLogin();
            Assert.True(lp.GetInvalidText().Equals("The username and password you entered did not match any account."));
            Console.WriteLine("Invalid username try again");
        }

        [Test]
        public void InvalidPasswordLogin()
        {
            HomePage hp = new HomePage();
            LoginPage lp = new LoginPage();
            AccountLandingPage alp = new AccountLandingPage();
            hp.ClickLoginBtn();
            lp.EnterPracticeCode("SahelM");
            lp.EnterLoginCredentials("johncena206", "Wrestling123456");
            lp.PressLogin();
            Assert.True(lp.GetInvalidText().Equals("The username and password you entered did not match any account."));
            Console.WriteLine("Invalid password try again");
        }

    }
}
