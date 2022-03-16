Feature: Notification module
	
	I want to Load more, Show less, Delete, Mark as read, Select and unselect notifications
@mytag1
Scenario: Load more notifications
	Given I navitaged to Notification Page
	When I click on Load More
	Then more notifications will be displayed
@mytag2
Scenario: Show less notifications
    Given I navitaged to Notification Page
    And I have loded more notifications
    When I click on Show less
    Then less notifications will be displayed
@mytag3
Scenario: Mark all as read
   Given I navitaged to Profile Page and hover the mouse on the Notification menu
   When I click on the Mark all as read
   Then the notification icon will disappear
@mytag4
Scenario: Delete notifications
   Given I navitaged to Notification Page
   When I Click on the check box of the notification
   And I click on the Deletion tab
   Then Selected nitification will be deleted
@mytag5
Scenario: Select notification
   Given I navitaged to Notification Page
   When I Select the check box of a notification
   Then the notification is selected
@mytag6
Scenario: UnSelect notification
   Given I navitaged to Notification Page
   When I Select and unselect the check box of a notification
   Then the notification is unselected
