Feature: Change Password

	I want to change the login password
	
@mytag
Scenario: Change the old password to a new one
	Given I have navigated to porfile page and hover the mouse to UI dropdown menu
	And I click on change password menu
    And I enter the old and new password details
	When I click Save button to save the new password
	Then the new password will be saved and I reverse the password for further login purpose
    
