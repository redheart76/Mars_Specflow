using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class AddDescriptionToProfile
    {
        
            private readonly ScenarioContext _scenarioContext;

            public AddDescriptionToProfile(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have clicked on description edit button")]
            public void GivenIHaveClickedOnDescriptionEditButton()
            {
            Pages.ProfilePage.addDescription();
            }

            [Given(@"I type in something I like to tell the people")]
            public void GivenIITypeInSomethingILikeToTellThePeople()
            {
            Pages.ProfilePage.enterDescriptionDetails();
            }

            [When(@"I press Save button")]
            public void WhenIPressSaveButton()
            {
            Pages.ProfilePage.saveDescription();
            }

            [Then(@"the new description will be saved")]
            public void ThenTheNewDescriptionWillBeSaved()
            {
            Pages.ProfilePage.AssertDescription();
            }
        }
}
