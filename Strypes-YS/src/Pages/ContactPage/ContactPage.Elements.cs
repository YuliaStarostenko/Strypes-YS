using OpenQA.Selenium;

namespace Strypes_YS.src.Pages.ContactPage
{
    public partial class ContactPage
    {
        public IWebElement FirstNameBox => FindElement(By.Name("firstname"));

        public IWebElement LastNameBox => FindElement(By.Name("lastname"));

        public IWebElement EmailBox => FindElement(By.Name("email"));

        public IWebElement CompanyNameBox => FindElement(By.Name("company"));

        public IWebElement MessageBox => FindElement(By.Name("message"));

        public IWebElement PolicyAndTermsConsentCheckBox => FindElement(By.Name("LEGAL_CONSENT.subscription_type_4681882"));

        public IWebElement SubscribeConsentCheckBox => FindElement(By.Name("LEGAL_CONSENT.subscription_type_4673944"));

        public IWebElement SendButton => FindElement(By.XPath("//input[@type='submit']"));

        public IWebElement SubmittedMessage => FindElement(By.XPath("//div[starts-with(@class, 'submitted-message')]"));
        
        public IWebElement EmailFormatMessage => FindElement(By.XPath("//ul[@class='no-list hs-error-msgs inputs-list']//label"));

        public IWebElement AllFieldsRequestMessage => FindElement(By.ClassName("hs_error_rollup"));

        public IWebElement EmailRequiredFieldMessages => FindElement(By.XPath("//*[@id='hsForm_9246f6ce-b893-4249-8362-96d17c0861f5']/fieldset[2]/div/ul/li/label"));

        public IWebElement PolicyAndTermsRequiredFieldMessages => FindElement(By.XPath("//*[@id='hsForm_9246f6ce-b893-4249-8362-96d17c0861f5']/fieldset[5]/div/div[1]/div/div/ul/li/label"));
    }
}
