using TechTalk.SpecFlow;

namespace AcceptanceTests.Support
{
    public class StepBase
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            if (Device.Driver == null || Device.Driver.SessionId == null)
                Device.Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
                Device.TakeErrorScreenshot(ScenarioContext.Current.ScenarioInfo.Title);
                
            Device.Driver.Quit();
        }
    }
}