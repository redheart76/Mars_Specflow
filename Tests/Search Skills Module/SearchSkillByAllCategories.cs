using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class SearchSkillByAllCategories
    {
        
            private readonly ScenarioContext _scenarioContext;

            public SearchSkillByAllCategories(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to Home page")]
            public void GivenIHaveNavigatedToHomePage()
            {
            Pages.ProfilePage.goToHomePage();
            }

            [Given(@"I enter the Search Condition")]
            public void GivenIEnterTheSearchCondition()
            {
            Pages.HomePage.searchCondition();
            }

            [When(@"I click on Search skill button")]
            public void WhenIClickOnSearchSkillButton()
            {
            Pages.HomePage.searchSkillBTN();
            }

            [Then(@"the result will be displayed")]
            public void ThenTheResultWillBeDisplayed()
            {
            Pages.SearchPage.resultByAllCategories();
            }
        }
}
