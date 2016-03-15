using System;
using System.IO;
using OpenQA.Selenium;
using System.Drawing.Imaging;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

namespace AcceptanceTests.Support
{
    public class Device
    {
        public static AppiumDriver<AppiumWebElement> Driver { get; private set; }

        public static void TakeErrorScreenshot(string title)
        {
            var timestamp = DateTime.Now.ToString("dd-MMM-yyyy hh.mm.ss");
            var currentDir = Environment.CurrentDirectory;
            const string folderName = "\\ErrorScreenshots";

            Directory.CreateDirectory(currentDir + folderName);

            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

            screenshot.SaveAsFile(currentDir + folderName + "\\" + title + " - " + timestamp + ".png", ImageFormat.Png);
        }

        public static void Initialize()
        {
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "Zeta Reticuli");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "5.1.1");
            capabilities.SetCapability("appPackage", "ae.propertyfinder.propertyfinder");
            capabilities.SetCapability("appActivity", "ae.propertyfinder.MainActivity");

            Driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities,
                TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(4));
        }
    }
}