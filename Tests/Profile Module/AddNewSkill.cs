using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class AddNewSkill
    {
        
            private readonly ScenarioContext _scenarioContext;

            public AddNewSkill(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have clicked on Skill tab")]
            public void GivenIHaveClickedOnSkillTab()
            {
            Pages.ProfilePage.clickSkill();
            }

            [Given(@"I click on Add new button")]
            public void GivenIClickOnAddNewButton()
            {
            Pages.ProfilePage.newSkill();
            }

            [Given(@"I enter my skill details")]
            public void GivenIEnterMySkillDetails()
            {
            Pages.ProfilePage.SkillDetails();
            }

            [When(@"I click on Add button")]
            public void WhenIClickOnAddButton()
            {
            Pages.ProfilePage.saveSkill();
            }

            [Then(@"the skill will be saved")]
            public void ThenTheSkillWillBeSaved()
            {
            Pages.ProfilePage.assertSkillSaved();
            }
        }
}
