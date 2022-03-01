Feature: Add new skill
	
	I want to add a new skill to my profile
	
@mytag
Scenario: Add a skill
	Given I have clicked on Skill tab
	And I click on Add new button
    And I enter my skill details
	When I click on Add button
	Then the skill will be saved
