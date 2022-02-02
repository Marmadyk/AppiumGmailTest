using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace AppiumAndroidTest.PageObjects
{
    public class MainPage : BasePage
    {
        public MainPage(AppiumDriver<AndroidElement> _driver) : base(_driver) { }

        private readonly string tapNewEmail = "com.google.android.gm:id/compose_button";
        private readonly string tapNavigationDrawer = "//android.widget.ImageButton[@content-desc='Open navigation drawer']";
        private readonly string tapSentEmails = "//*[contains(@text, 'Sent')]";

        public void CreateEmail()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElementById(tapNewEmail)));
            _driver.FindElementById(tapNewEmail).Click();
        }

        public void TapNavigationDrawer()
        {
            _driver.FindElementByXPath(tapNavigationDrawer).Click();
        }

        public void TapSentEmails()
        {
            _driver.FindElementByXPath(tapSentEmails).Click();
        }
    }
}
