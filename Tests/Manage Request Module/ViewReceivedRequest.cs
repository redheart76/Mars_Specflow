using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class ViewReceivedRequest
    {
        
            private readonly ScenarioContext _scenarioContext;

            public ViewReceivedRequest(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to profile page and hove the mouse on Received Request tab")]
            public void GivenIHaveNavigatedToProfilePageAndHoveTheMouseOnReceivedRequestTab()
            {
            Pages.ProfilePage.ReceivedRequestDropDown();
            }

            [When(@"I click on the Received Request from the drop down menu")]
            public void WhenIClickOnTheReceivedRequestFromTheDropDownMenu()
            {
            Pages.ProfilePage.receivedRequestMenu();
            }

            [Then(@"I can see the request in the Received Requests page")]
            public void ThenICanSeeTheRequestInTheReceivedRequestsPage()
            {
            Pages.ReceivedRequestPage.assertReceivedRequest();
            }
        }
}
