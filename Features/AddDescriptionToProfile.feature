Feature: Add or Edit the description in my profile
	
	I want to add or edit the description 
	
@mytag
Scenario: Add or Edit the description
	Given I have clicked on description edit button
	And I type in something I like to tell the people
	When I press Save button
	Then the new description will be saved
