using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PracticeAutomation.Browsers;
using System;

namespace PracticeAutomation
{
    public class Base : IBase
    {
        public Base(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; set; }
        
        public void ScrollDown()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

        }

        public void Wait()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public void SetWindow()
        {
          Driver.Manage().Window.Maximize();
        }

        public void StopBrowser()
        {
            Driver.Quit();
        }
    }
}
