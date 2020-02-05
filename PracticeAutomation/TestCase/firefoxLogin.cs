using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PracticeAutomation
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxLogin : Base
    {
       public FirefoxLogin()
        {

            Driver = new FirefoxDriver();
        }

        [Test]
        public void Operations()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Name("email")).SendKeys("manishabhanot96@gmail.com");
            Driver.FindElement(By.Name("pass")).SendKeys("kudrat123");
            Driver.FindElement(By.Id("loginbutton")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Driver.FindElement(By.Id("pageLoginAnchor")).Click();
            Driver.Quit();
            
        }
    }
}
