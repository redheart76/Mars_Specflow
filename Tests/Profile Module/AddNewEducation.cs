using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class AddNewEducation
    {
       

            private readonly ScenarioContext _scenarioContext;

            public AddNewEducation(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I click on Education tab")]
            public void GivenIClickOnEducationTab()
            {
            Pages.ProfilePage.clickOnEducation();
            }

            [Given(@"I click on Add New button")]
            public void GivenIClickOnAddNewButton()
            {
            Pages.ProfilePage.addNewEdu();
            }

            [Given(@"I enter my education details")]
            public void GivenIEnterMyEducationDetails()
            {
            Pages.ProfilePage.enterEducationDetails();
            }

            [When(@"I click Add button")]
            public void WhenIClickAddButton()
            {
            Pages.ProfilePage.clickandSaveEducation();
            }

            [Then(@"my education has been saved")]
            public void ThenMyEducationHasBeenSaved()
            {
            Pages.ProfilePage.assertEduAdded();
            }
        }
}
