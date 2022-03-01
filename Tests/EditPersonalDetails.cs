using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class EditPersonalDetails
    {
       
            private readonly ScenarioContext _scenarioContext;

            public EditPersonalDetails(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have gone to my profile")]
            public void GivenIHaveGoneToMyProfile()
            {
            Pages.ProfilePage.myProfile();
            
            }

            [When(@"I selected the options")]
            public void WhenISelectedTheOptions()
            {
            Pages.ProfilePage.personalDetails();

            }

            [Then(@"my details has been changed")]
            public void ThenMyDetailsHasBeenChanged()
            {
            Pages.ProfilePage.earnTarget();
            }
        }
}
