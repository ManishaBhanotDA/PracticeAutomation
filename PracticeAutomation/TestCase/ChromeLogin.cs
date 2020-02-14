using NUnit.Framework;
using OpenQA.Selenium;
using PracticeAutomation.Browsers;
using OpenQA.Selenium.Chrome;
namespace PracticeAutomation
{

    [TestFixture]
   
    public class FB : Base
    {
      
        new IWebDriver Driver = new ChromeDriver();

        public FB(IWebDriver driver) : base(driver)
        {
        }

        [Test]
        public void Login()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            var b = new Base(Driver);
            b.SetWindow();
           // b.ScrollDown();

            Driver.FindElement(By.Name("email")).SendKeys("manishabhanot96@gmail.com");
            Driver.FindElement(By.Name("pass")).SendKeys("kudrat123");
            Driver.FindElement(By.Id("loginbutton")).Click();
            Driver.FindElement(By.Id("pageLoginAnchor")).Click();
        }

      
    }

}
