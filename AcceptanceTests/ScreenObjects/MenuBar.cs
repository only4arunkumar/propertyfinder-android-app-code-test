using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AcceptanceTests.ScreenObjects
{
    public class MenuBar
    {
        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/action_filter")]
        public IWebElement SearchSettingsButton;

        [FindsBy(How = How.Id, Using = "android:id/up")]
        public IWebElement BackButton;

        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/action_clear_settings")]
        public IWebElement ClearSettingsButton;
    }
}