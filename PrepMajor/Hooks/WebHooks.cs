using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.IO;
using System.Reflection;

namespace PrepMajor.Hooks
{
    [Binding]
    public sealed class WebHooks
    {
        public static IWebDriver driver;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario 
        }
    }
}
