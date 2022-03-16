using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class ChatHistory
    {
        
            private readonly ScenarioContext _scenarioContext;

            public ChatHistory(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have navigated to the Message Page")]
            public void GivenIHaveNavigatedToTheMessagePage()
            {
            Pages.ProfilePage.gotoMessagePage();
            }

            [When(@"I click on the person who I want to chat with")]
             public void WhenIClickOnThePersonWhoIWantToChatWith()
            {
            Pages.MessagePage.personChattingWith();
            }
            [Then(@"the chat history will be displayed")]
            public void ThenTheChatHistoryWillBeDisplayed()
            {
            Pages.MessagePage.chatHistory();
            }
    }
}
