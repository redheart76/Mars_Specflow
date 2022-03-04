using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class DeleteListedSkill
    {
        
            private readonly ScenarioContext _scenarioContext;

            public DeleteListedSkill(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to Listing Management Page")]
            public void GivenIHaveNavigatedToListingManagementPage()
            {
            Pages.ProfilePage.gotoListingManagementPage();
            }

            [Given(@"I click on the Delete icon of the selected skill")]
            public void GivenIClickOnTheDeleteIconOfTheSelectedSkill()
            {
            Pages.ListingManagermentPage.deleteSkill();
            }

            [When(@"I click on Yes to accept the deletion")]
            public void WhenIClickOnYesToAcceptTheDeletion()
            {
            Pages.ListingManagermentPage.acceptDeletion();
            }

            [Then(@"the selected skill will be deleted")]
            public void ThenTheSelectedSkillWillBeDeleted()
            {
            Pages.ListingManagermentPage.IsElementPresent();
            }
        }
}
