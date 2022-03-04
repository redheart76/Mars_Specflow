using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class SearchSkillBySubcategories
    {
       
            private readonly ScenarioContext _scenarioContext;

            public SearchSkillBySubcategories(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to Search page")]
            public void GivenIHaveNavigatedToSearchPage()
            {
            Pages.ProfilePage.gotoSearchPage();
            }

            [Given(@"I select a subcategory")]
            public void GivenISelectASubcategory()
            {
            Pages.SearchPage.GraphicsDesignCategory();
            }

            [When(@"I select another subcategory")]
            public void WhenISelectAnotherSubcategory()
            {
            Pages.SearchPage.WebMobileDesign();
            }

            [Then(@"the expected result should be displayed")]
            public void ThenTheExpectedResultShouldBeDisplayed()
            {
            Pages.SearchPage.searchResult();
            }
        }
}
