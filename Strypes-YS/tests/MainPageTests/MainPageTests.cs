namespace Strypes_YS.tests.MainPageTests
{
    [TestFixture]
    public class MainPageTests : MainPageBaseTest
    {
        [SetUp]
        public void TestInit()
        {
            MainPage.Open();
        }

        [Test]
        public void ContactPageNavigated_When_ClickContactButtonAtMainPage()
        {
            MainPage.ContactButton.Click();

            Assert.That(Driver.Url,Is.EqualTo(ContactPage.Url), "The expected Url was not found on the page.");
        }

    }
}
