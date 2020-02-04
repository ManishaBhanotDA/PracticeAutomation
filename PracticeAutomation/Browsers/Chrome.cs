using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticeAutomation.Browsers
{
    [TestFixture]
   public class Chrome : Base
    {
        public Chrome() 
        {
            Driver = new ChromeDriver();
        }
    }
}
