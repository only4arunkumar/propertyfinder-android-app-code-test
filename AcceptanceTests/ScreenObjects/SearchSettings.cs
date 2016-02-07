using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AcceptanceTests.ScreenObjects
{
    public class SearchSettings
    {
        [FindsBy(How = How.Name, Using = "Bedrooms")]
        public IWebElement BedroomSettings;
    }
}