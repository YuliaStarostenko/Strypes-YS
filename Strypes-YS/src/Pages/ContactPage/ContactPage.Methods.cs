using OpenQA.Selenium;
using Strypes_YS.src.Pages.ContactPage.Models;

namespace Strypes_YS.src.Pages.ContactPage
{
    public partial class ContactPage : BasePage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://strypes.eu/contact/";

        public void FillInContactFormInfo(ContactFormModel formModel)
        {
            FirstNameBox.SendKeys(formModel.FirstName);
            LastNameBox.SendKeys(formModel.LastName);
            CompanyNameBox.SendKeys(formModel.CompanyName);
            EmailBox.SendKeys("georgeMartin@gmail.com");
            MessageBox.SendKeys(formModel.Messages);
        }
    }
}
