using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumAndroidTest.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(AppiumDriver<AndroidElement> _driver) : base(_driver) { }

        private readonly string tapGoIt = "com.google.android.gm:id/welcome_tour_got_it";
        private readonly string tapGoToGmail = "com.google.android.gm:id/action_done";

        public void GoToGmail()
        {
            _driver.FindElementById(tapGoIt).Click();
            _driver.FindElementById(tapGoToGmail).Click();
        }
    }
}
