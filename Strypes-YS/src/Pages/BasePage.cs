using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Strypes_YS.src.Pages
{
    public abstract class BasePage
    {
        private const int WaitForElementTimeout = 30;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            WebDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(WaitForElementTimeout));
        }
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait WebDriverWait { get; set; }
        public abstract string Url { get; }

        public void Open()
        {
            Driver.Navigate().GoToUrl(Url);
            Driver.Manage().Window.Maximize();
        }

        protected void WaitForAjax()
        {
            var js = (IJavaScriptExecutor)Driver;
            WebDriverWait.Until(wd => js.ExecuteScript("return jQuery.active").ToString() == "0");

        }

        protected IWebElement FindElement(By locator)
        {
            return WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }
    }
}
