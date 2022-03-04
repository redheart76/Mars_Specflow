Feature: Edit Listed Skills
	
	I want to edit my skill in my skill listings
	
@mytag
Scenario: Edit a listed skill
	Given I have navigated to Listing Management page
	And I click on the Edit icon
    And I edit the description of the skill
	When I click on the Save button
	Then the new description of the skill will be saved
