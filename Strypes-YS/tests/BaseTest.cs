using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WebDriverManager;

namespace Strypes_YS.tests
{
    public class BaseTest
    {
        protected static IWebDriver Driver;

        [OneTimeSetUp]
        public virtual void BaseSetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            Driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public virtual void BaseTearDown()
        {
            Driver.Quit();
        }
    }
}
