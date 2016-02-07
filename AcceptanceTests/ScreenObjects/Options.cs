using OpenQA.Selenium;
using AcceptanceTests.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace AcceptanceTests.ScreenObjects
{
    public class Options
    {
        [FindsBy(How = How.Id, Using = "android:id/button1")]
        public IWebElement OkButton;

        public Options SelectOption(string option)
        {
            Device.Driver.FindElementByName(option).Click();

            return this;
        }
    }
}