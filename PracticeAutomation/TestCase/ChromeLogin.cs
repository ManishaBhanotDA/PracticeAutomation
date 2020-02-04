using NUnit.Framework;
using OpenQA.Selenium;
using PracticeAutomation.Browsers;
using OpenQA.Selenium.Chrome;
namespace PracticeAutomation
{

    [TestFixture]
    [Parallelizable]
    public  class FB : Chrome
    {
      
        [Test]
        public void Login()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Name("email")).SendKeys("manishabhanot96@gmail.com");
            Driver.FindElement(By.Name("pass")).SendKeys("kudrat123");
            Driver.FindElement(By.Id("loginbutton")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        
    }
}