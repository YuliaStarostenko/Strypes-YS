using Strypes_YS.tests.ContactPageTests.Factories;

namespace Strypes_YS.tests.ContactPageTests.Tests
{
    [TestFixture]
    public class ContactPageTests : ContactPageBaseTest
    {
        [SetUp]
        public void TestInit()
        {
            ContactPage.Open();
        }

        [Test]
        public void ContactFormFilled_When_SubmitFullValidData()
        {
            var fullContactForm = ContactFormFactory.CreateFullContactFormModel();

            ContactPage.FillInContactFormInfo(fullContactForm);
            ContactPage.PolicyAndTermsConsentCheckBox.Click();
            ContactPage.SubscribeConsentCheckBox.Click();
            ContactPage.SendButton.Click();

            ContactPage.AssertSuccessSubmitFormMessage();
        }

        [Test]
        public void CorrectRequestMessagesReceived_When_TrySendEmptyForm()
        {
            ContactPage.SendButton.Click();

            ContactPage.AssertRequestMessagesForEmptyFormSubmition();
        }

        [Test]
        public void CorrectSuccessMessagesReceived_When_SubmitRequiredFieldOnly()
        {
            var requiredContactForm = ContactFormFactory.CreateRequiredContactFormModel();

            ContactPage.FillInContactFormInfo(requiredContactForm);
            ContactPage.PolicyAndTermsConsentCheckBox.Click();
            ContactPage.SendButton.Click();

            ContactPage.AssertSuccessSubmitFormMessage();
        }
        
        [TestCase("halfEmail")]
        [TestCase("halfEmail@")]
        [TestCase("halfEmail@gdf@gmail.com")]
        [TestCase("1111111")]
        [TestCase("агфгсф@фдг.гфд")]
        public void CorrectMessagesReceived_When_ТrySubmitIncorrectEmailFormat(string email)
        {
            ContactPage.EmailBox.SendKeys(email);

            ContactPage.AssertEmailFormatMessage();
        }
    }
}
