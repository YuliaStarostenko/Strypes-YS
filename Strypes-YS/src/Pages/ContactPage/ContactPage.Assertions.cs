namespace Strypes_YS.src.Pages.ContactPage
{
    public partial class ContactPage
    {
        public void AssertSuccessSubmitFormMessage() 
        { 
            WaitForAjax();
            Assert.That(SubmittedMessage.Text, Is.EqualTo("Thank you for submitting the form."));  
        }

        public void AssertRequestMessagesForEmptyFormSubmition()
        {
            Assert.That(AllFieldsRequestMessage.Text, Is.EqualTo("Please complete all required fields."));
            Assert.That(EmailRequiredFieldMessages.Text, Is.EqualTo("Please complete this required field."));
            Assert.That(PolicyAndTermsRequiredFieldMessages.Text, Is.EqualTo("Please complete this required field."));
        }
        
        public void AssertEmailFormatMessage() 
        { 
            Assert.That(EmailFormatMessage.Text, Is.EqualTo("Email must be formatted correctly."));  
        }
    }
}
