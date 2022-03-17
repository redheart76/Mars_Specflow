using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class Notifications
    {
        
            private readonly ScenarioContext _scenarioContext;

            public Notifications(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I navitaged to Notification Page")]
            public void GivenINavitagedToNotificationPage()
            {
            Pages.ProfilePage.gotoNotificationPage();
            }

            [When(@"I click on Load More")]
            public void WhenIClickOnLoadMore()
            {
            Pages.NotificationPage.loadMoreNotificaions();
            }

            [Then(@"more notifications will be displayed")]
            public void ThenMoreNotificationsWillBeDisplayed()
            {
            Pages.NotificationPage.assertLoadedNotification();
            }

            [Given(@"I have loded more notifications")]
            public void GivenIHaveLodedMoreNotifications()
            {
            Pages.NotificationPage.loadMoreNotificaions();
            }

            [When(@"I click on Show less")]
            public void WhenIClickOnShowLess()
            {
            Pages.NotificationPage.showLessNotificaitons();
            }

            [Then(@"less notifications will be displayed")]
            public void ThenLessNotificationsWillBeDisplayed()
            {
            Pages.NotificationPage.IsElementPresent();
            }


            [When(@"I Click on the check box of the notification")]
            public void WhenIClickOnTheCheckBoxOfTheNotification()
            {
            Pages.NotificationPage.checkBox3();
            }

            [When(@"I click on the Deletion tab")]
             public void WhenIClickOnTheDeletionTab()
            {
            Pages.NotificationPage.notificationDeletion();
            }

            [Then(@"Selected nitification will be deleted")]
            public void ThenSelectedNitificationWillBeDeleted()
            {
            Pages.NotificationPage.deletedElement();
            }


            [When(@"I Select the check box of a notification")]
            public void WhenISelectTheCheckBoxOfANotification()
            {
            Pages.NotificationPage.checkBox1();
            }

            [Then(@"the notification is selected")]
            public void ThenTheNotificationIsSelected()
            {
            Pages.NotificationPage.checkbox1Selected();
            }
  
            [When(@"I Select and unselect the check box of a notification")]
             public void WhenISelectAndUnselectTheCheckBoxOfANotification()
            {
            Pages.NotificationPage.checkbox2UnSelected();
            }

            [Then(@"the notification is unselected")]
            public void ThenTheNotificationIsUnselected()
            {
            Pages.NotificationPage.checkbox2UnSelected();
            }

           
            [Given(@"I navitaged to Profile Page and hover the mouse on the Notification menu")]
            public void GivenINavitagedToProfilePageAndHoverTheMouseOnTheNotificationMenu()
            {
            Pages.ProfilePage.noitificationDropdownHover();
            }

            [When(@"I click on the Mark all as read")]
            public void WhenIClickOnTheMarkAllAsRead()
            {
            Pages.ProfilePage.markAll();
            }

            [Then(@"the notification icon will disappear")]
            public void ThenTheNotificationIconWillDisappear()
            {
            Pages.ProfilePage.IsNoitficationElementPresent();
            }
    }
}
