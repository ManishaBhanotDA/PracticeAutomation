using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace PracticeAutomation
{
    [TestFixture]
  public class FireFox : Base
    {
        public FireFox()
        {
            Driver = new FirefoxDriver();
        }
    }
}

