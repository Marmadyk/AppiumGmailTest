using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumAndroidTest
{
    [TestFixture]
    public class BaseTest
    {
        protected AppiumDriver<AndroidElement> _driver;

        [SetUp]
        protected void DoBeforeEach()
        {
            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability("platformName", "Android");
            driverOption.AddAdditionalCapability("deviceName", "emulator-5554");
            driverOption.AddAdditionalCapability("appActivity", "com.google.android.gm.GmailActivity");
            driverOption.AddAdditionalCapability("appPackage", "com.google.android.gm");
            driverOption.AddAdditionalCapability("chromedriverExecutable", @"/Users/applecity/Desktop/chromedriver");
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), driverOption);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [TearDown]
        protected void DoAfterEach()
        {
            _driver.Quit();
        }
    }
}
