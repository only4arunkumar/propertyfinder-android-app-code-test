using OpenQA.Selenium;

namespace AcceptanceTests.Support
{
    public class Helpers
    {
        public static bool DoesElementExist(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}