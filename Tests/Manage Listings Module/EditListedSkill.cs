using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class EditListedSkill
    {

        
            private readonly ScenarioContext _scenarioContext;

            public EditListedSkill(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to Listing Management page")]
            public void GivenIHaveNavigatedToListingManagementPage()
            {
            Pages.ProfilePage.gotoListingManagementPage();
            }

            [Given(@"I click on the Edit icon")]
            public void GivenIClickOnTheEditIcon()
            {
            Pages.ListingManagermentPage.editSkill();
            }

            [Given(@"I edit the description of the skill")]
            public void GivenIEditTheDescriptionOfTheSkill()
            {
            Pages.ServiceListingPage.editSkillDescription();
            }

            [When(@"I click on the Save button")]
            public void WhenIClickOnTheSaveButton()
            {
            Pages.ServiceListingPage.saveSkill();
            }

            [Then(@"the new description of the skill will be saved")]
            public void ThenTheNewDescriptionOfTheSkillWillBeSaved()
            {
            Pages.ListingManagermentPage.assertSkillDescriptionIsDisplayed();
            }
        }
}
