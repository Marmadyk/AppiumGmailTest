using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumAndroidTest.PageObjects
{
    public class BasePage
    {
        protected AppiumDriver<AndroidElement> _driver;
        public BasePage(AppiumDriver<AndroidElement> _driver)
        {
            this._driver = _driver;
        }
    }
}
