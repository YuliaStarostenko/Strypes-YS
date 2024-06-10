using OpenQA.Selenium;

namespace Strypes_YS.src.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://strypes.eu/";
    }
}
