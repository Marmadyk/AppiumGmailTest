using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumAndroidTest.PageObjects
{
    public class EmailPage : BasePage
    {
        public EmailPage(AppiumDriver<AndroidElement> _driver) : base(_driver) { }

        private readonly string tapWriteTo = "com.google.android.gm:id/to";
        private readonly string enterEmail = "com.google.android.gm:id/to";
        private readonly string email = "appiumtestproject@gmail.com";
        private readonly string tapWriteSubject = "com.google.android.gm:id/subject";
        private readonly string enterSubject = "com.google.android.gm:id/subject";
        private readonly string subject = "Test gmail app with appium";
        private readonly string tapEmailBody = "com.google.android.gm:id/body";
        private readonly string enterEmailText = "com.google.android.gm:id/body";
        private readonly string text = "Success!";
        private readonly string tapSendEmail = "com.google.android.gm:id/send";

        public void WriteTo()
        {
            _driver.FindElementById(tapWriteTo).Click();
            _driver.FindElementById(enterEmail).SendKeys(email);
            _driver.HideKeyboard();
        }

        public void WriteSubject()
        {
            _driver.FindElementById(tapWriteSubject).Click();
            _driver.FindElementById(enterSubject).SendKeys(subject);
            _driver.HideKeyboard();
        }

        public void WriteEmailBody()
        {
            _driver.FindElementById(tapEmailBody).Click();
            _driver.FindElementById(enterEmailText).SendKeys(text);
            _driver.HideKeyboard();
        }

        public void SendEmail()
        {
            _driver.FindElementById(tapSendEmail).Click();
        }
    }
}
