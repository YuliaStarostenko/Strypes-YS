using Strypes_YS.src.Pages.ContactPage;

namespace Strypes_YS.tests.ContactPageTests
{
    public class ContactPageBaseTest : BaseTest
    {
        protected static ContactPage ContactPage;

        [SetUp]
        public void SetUp()
        {
            ContactPage = new ContactPage(Driver);
        }
    }
}
