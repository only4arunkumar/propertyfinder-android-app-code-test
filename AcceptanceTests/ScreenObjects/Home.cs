using System.Linq;
using OpenQA.Selenium;
using AcceptanceTests.Support;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;

namespace AcceptanceTests.ScreenObjects
{
    public class Home
    {
        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/sort_button")]
        public IWebElement SortButton;

        [FindsBy(How = How.Name, Using = "RENT")]
        public IWebElement RentTab;
        
        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/start_button")]
        private IWebElement _startButton;

        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/rateLater")]
        private IWebElement _rateLaterButton;

        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/title")]
        private IList<IWebElement> _allResultsFacts;

        [FindsBy(How = How.Id, Using = "ae.propertyfinder.propertyfinder:id/price")]
        private IList<IWebElement> _allResultsPrices;

        public Home Open()
        {
            if(Helpers.DoesElementExist(_startButton))
                _startButton.Click();

            if (Helpers.DoesElementExist(_rateLaterButton))
                _rateLaterButton.Click();

            return this;
        }

        public bool AllResultsHaveNumberOfBedrooms(string numberOfBedrooms)
        {
            return _allResultsFacts.All(facts => facts.Text.Contains(numberOfBedrooms + " bed"));
        }

        public bool IsTheResultListOrderedByHighestPriceFirst()
        {
            for (var i = 0; i < (_allResultsPrices.Count - 1); i++)
            {
                var resultCurrencyValue = int.Parse(_allResultsPrices[i].Text.Replace(",", ""));
                var nextResultCurrencyValue = int.Parse(_allResultsPrices[i + 1].Text.Replace(",", ""));

                if (resultCurrencyValue < nextResultCurrencyValue)
                    return false;
            }
            return true;
        }
    }
}