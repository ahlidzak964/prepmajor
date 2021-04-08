
using OpenQA.Selenium;
using PrepMajor.Hooks;
using System;
using System.Threading;

namespace PrepMajor.PageObject
{
    class StudentRegistrationPages
    {
        public IWebDriver driver;
        private By signUpButton = By.XPath("//*[@id='header']/div/div[2]/div/div/div/div[3]/a[2]/span");
        private By userNameTextBox = By.CssSelector("div:nth-child(1) > div:nth-child(1) > div > input");
        private By emailTextBox = By.Name("email");
        private By passwordTextBox = By.XPath("//div[@class='stm_lms_register_wrapper']//input[@placeholder='Enter password']");
        private By confirmpasswordTextBox = By.CssSelector("div:nth-child(2) > div:nth-child(2) > div > input");
        private By termAndConditionCheckBox = By.CssSelector("#stm-lms-register > div.stm_lms_register_wrapper > div:nth-child(3) > div > label > span > input[type=checkbox]");
        private By registerButton = By.XPath("//span[normalize-space()='Register']");

    
        public StudentRegistrationPages()
        {
            driver = WebHooks.driver;

        }

        public void NavigateToPrepmajorSite()
        {
            driver.Navigate().GoToUrl(@"https://test.prepmajor.com");
        }

        public void ClickSignUpButton()
        {
            driver.FindElement(signUpButton).Click();
        }

        public void EnterUserName(string userName)
        {
            Thread.Sleep(3000);
            driver.FindElement(userNameTextBox).SendKeys(userName);
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(emailTextBox).SendKeys(email);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordTextBox).SendKeys(password);
        }

        public void EnterconfirmPassword(string Cpassword)
        {
            driver.FindElement(confirmpasswordTextBox).SendKeys(Cpassword);
        }

        public void SelecttermsOfUseAndConditionCheckBox()
        {
            driver.FindElement(termAndConditionCheckBox).Click();
        }

        public void ClickRegisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

         public bool IsUserNameDisplayed()
         {
            return driver.Url == "test.prepmajor.com/user-account";
         }
    }
}
