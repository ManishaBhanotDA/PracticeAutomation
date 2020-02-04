using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PracticeAutomation
{
    class firefoxLogin
    {
        IWebDriver Driver = new FirefoxDriver();
        [SetUp]
        public void start()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void Operations()
        {
            Driver.FindElement(By.Name("email")).SendKeys("manishabhanot96@gmail.com");
            Driver.FindElement(By.Name("pass")).SendKeys("kudrat123");
            Driver.FindElement(By.Id("loginbutton")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");



        }
    }
}
