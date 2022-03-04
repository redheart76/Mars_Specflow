using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
   

        [Binding]
        public class AddLanguageToProfile
        {
            private readonly ScenarioContext _scenarioContext;

            public AddLanguageToProfile(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have click on Add New")]
            public void GivenIHaveClickOnAddNew()
            {
            Pages.ProfilePage.addLanguageBTN();
            }

            [Given(@"I have entered a new language")]
            public void GivenIHaveEnteredANewLanguage()
            {
            Pages.ProfilePage.enterLanguage();
            }

            [Given(@"I have selected the language level")]
            public void GivenIHaveSelectedTheLanguageLevel()
            {
            Pages.ProfilePage.selectLevel();
            }

            [When(@"I press add")]
            public void WhenIPressAdd()
            {
            Pages.ProfilePage.clickAddtoSaveLanguage();
            }

            [Then(@"the new language has been added")]
            public void ThenTheNewLanguageHasBeenAdded()
            {
            Pages.ProfilePage.assertLanguageAdded();
            }
        }
   }

