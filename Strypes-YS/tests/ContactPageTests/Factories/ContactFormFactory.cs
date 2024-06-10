using Strypes_YS.src.Pages.ContactPage.Models;

namespace Strypes_YS.tests.ContactPageTests.Factories
{
    public static class ContactFormFactory
    {
        public static ContactFormModel CreateFullContactFormModel()
        {
            var formModel = new ContactFormModel
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Email = Faker.Internet.Email(),
                CompanyName = Faker.Company.Name(),
                Messages = Faker.Lorem.Sentence(),
            };
            return formModel;
        }
        
        public static ContactFormModel CreateRequiredContactFormModel()
        {
            var formModel = new ContactFormModel
            {
                FirstName = String.Empty,
                LastName = String.Empty,
                Email = Faker.Internet.Email(),
                CompanyName = String.Empty,
                Messages = String.Empty,
            };
            return formModel;
        }

    }
}
