using AppiumAndroidTest.PageObjects;
using NUnit.Framework;

namespace AppiumAndroidTest
{
    public class Tests : BaseTest
    {
        private readonly string actualText = "//*[@class='android.view.View']";
        private readonly string expectedText = "Success!";

        [Test]
        public void Test1()
        {
            var homePage = new HomePage(_driver);
            homePage.GoToGmail();

            var mainPage = new MainPage(_driver);
            mainPage.CreateEmail();

            var emailPage = new EmailPage(_driver);
            emailPage.WriteTo();
            emailPage.WriteSubject();
            emailPage.WriteEmailBody();
            emailPage.SendEmail();

            mainPage.TapNavigationDrawer();
            mainPage.TapSentEmails();

            Assert.AreEqual(_driver.FindElementByXPath(actualText).Text, expectedText);
        }
    }
}
