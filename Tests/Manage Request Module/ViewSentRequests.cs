using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class ViewSentRequests
    {
        
            private readonly ScenarioContext _scenarioContext;

            public ViewSentRequests(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to profile page and hove the mouse on Sent Request tab")]
            public void GivenIHaveNavigatedToProfilePageAndHoveTheMouseOnSentRequestTab()
            {
            Pages.ProfilePage.SentRequestDropDown();
            }

            [When(@"I click on the Sent Request from the drop down menu")]
            public void WhenIClickOnTheSentRequestFromTheDropDownMenu()
            {
            Pages.ProfilePage.sentRequestsMenu();
            }

            [Then(@"I can see the request in the Sent Requests page")]
            public void ThenICanSeeTheRequestInTheSentRequestsPage()
            {
            Pages.SentRequestPage.assertSentRequest();
            }
        }
}
