using Strypes_YS.src.Pages.MainPage;
using Strypes_YS.src.Pages.ContactPage;

namespace Strypes_YS.tests.MainPageTests
{
    public class MainPageBaseTest : BaseTest
    {
        protected static MainPage MainPage;

        protected static ContactPage ContactPage;

        [SetUp]
        public void SetUp() 
        {
            MainPage = new MainPage(Driver);
            ContactPage = new ContactPage(Driver);
        }
    }
}
