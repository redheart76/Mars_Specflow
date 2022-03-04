using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class ShareSkill
    {
        
            private readonly ScenarioContext _scenarioContext;

            public ShareSkill(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to Service Listing page to add describe my skill")]
            public void GivenIHaveNavigatedToServiceListingPageToAddDescribeMySkill()
            {
            Pages.ProfilePage.gotoServiceListing();
;            }

            [Given(@"I have entered the details of my skill")]
            public void GivenIHaveEnteredTheDetailsOfMySkill()
            {
            Pages.ServiceListingPage.newSkill();
            }

            [When(@"I click on Save button")]
            public void WhenIClickOnSaveButton()
            {
            Pages.ServiceListingPage.saveSkill();
            }

            [Then(@"my skill details will be saved")]
            public void ThenMySkillDetailsWillBeSaved()
            {
            Pages.ListingManagermentPage.assertTitleIsDisplayed();
            }
        }
}
