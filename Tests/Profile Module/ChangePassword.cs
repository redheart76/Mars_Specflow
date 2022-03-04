using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class ChangePassword
    {
       
            private readonly ScenarioContext _scenarioContext;

            public ChangePassword(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to porfile page and hover the mouse to UI dropdown menu")]
            public void GivenIHaveNavigatedToPorfilePageAndHoverTheMouseToUIDropdownMenu()
            {
            Pages.ProfilePage.uiDropdownHover();
            }

            [Given(@"I click on change password menu")]
            public void GivenIClickOnChangePasswordMenu()
            {
            Pages.ProfilePage.changePWmenu();
            }

            [Given(@"I enter the old and new password details")]
            public void GivenIEnterTheOldAndNewPasswordDetails()
            {
            Pages.ProfilePage.changePassword();
            }

            [When(@"I click Save button to save the new password")]
            public void WhenIClickSaveButtonToSaveTheNewPassword()
            {
            Pages.ProfilePage.savePW();
            }

            [Then(@"the new password will be saved and I reverse the password for further login purpose")]
            public void ThenTheNewPasswordWillBeSavedAndIReverseThePasswordForFurtherLoginPurpose()
            {
            Pages.ProfilePage.reversePW();
            }
        }
}
