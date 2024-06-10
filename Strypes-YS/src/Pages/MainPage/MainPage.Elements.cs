using OpenQA.Selenium;

namespace Strypes_YS.src.Pages.MainPage
{
    public partial class MainPage
    {
        public IWebElement ContactButton => FindElement(By.XPath("//ul[@id='menu-1-76b7430b']//a[.='Contact']"));

    }
}
