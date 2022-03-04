using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class SearchSkillByFilters
    {
        
            private readonly ScenarioContext _scenarioContext;

            public SearchSkillByFilters(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have clicked on Search and navigated to Search page")]
            public void GivenIHaveClickedOnSearchAndNavigatedToSearchPage()
            {
            Pages.ProfilePage.gotoSearchPage();
            }

            [When(@"I enter a user's name as the search filter")]
            public void WhenIEnterAUsersNameAsTheSearchFilter()
            {
            Pages.SearchPage.SearchByName();
            }

            [Then(@"the expected user should be displayed")]
            public void ThenTheExpectedUserShouldBeDisplayed()
            {
            Pages.SearchPage.searchResultOfName();
            }
        }
}
