using System;
using OpenQA.Selenium.Support.PageObjects;

namespace AcceptanceTests.Support
{
    public class App
    {
        public static T Screen<T>()
        {
            var screen = Activator.CreateInstance<T>();
            PageFactory.InitElements(Device.Driver, screen);

            return screen;
        }
    }
}