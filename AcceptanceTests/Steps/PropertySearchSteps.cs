using NUnit.Framework;
using TechTalk.SpecFlow;
using AcceptanceTests.Support;
using AcceptanceTests.ScreenObjects;

namespace AcceptanceTests.Steps
{
    [Binding]
    public class PropertySearchSteps : StepBase
    {
        [Given(@"I am on the Propertyfinder app home screen")]
        public void GivenIAmOnThePropertyfinderAppHomeScreen()
        {
            App.Screen<Home>().Open();
        }

        [When(@"I filer the results to show only ""(.*)"" bedroom properties")]
        public void WhenIFilerTheResultsToShowOnlyBedroomProperties(string numberOfBedrroms)
        {
            App.Screen<MenuBar>().SearchSettingsButton.Click();
            App.Screen<MenuBar>().ClearSettingsButton.Click();
            App.Screen<SearchSettings>().BedroomSettings.Click();
            App.Screen<Options>()
                .SelectOption(numberOfBedrroms)
                .OkButton.Click();
            App.Screen<MenuBar>().BackButton.Click();
        }

        [Then(@"the reslut list should  only contain ""(.*)"" bedroom properties")]
        public void ThenTheReslutListShouldOnlyContainBedroomProperties(string numberOfBedrroms)
        {
            Assert.IsTrue(App.Screen<Home>().AllResultsHaveNumberOfBedrooms(numberOfBedrroms));
        }

        [Given(@"I am viewing rental properties")]
        public void GivenIAmViewingRentalProperties()
        {
            App.Screen<Home>().RentTab.Click();
        }

        [When(@"I sort the result list by ""(.*)""")]
        public void WhenISortTheResultListBy(string sortCriteria)
        {
            App.Screen<Home>().RentTab.Click();
            App.Screen<Home>().SortButton.Click();
            App.Screen<Options>().SelectOption(sortCriteria);
        }

        [Then(@"the result list should be sorted by the highest price first")]
        public void ThenTheResultListShouldBeSortedByTheHighestPriceFirst()
        {
            Assert.IsTrue(App.Screen<Home>().IsTheResultListOrderedByHighestPriceFirst());
        }
    }
}
