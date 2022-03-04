Feature: Share Skill
	
	I want to share my skill to the people
	
@mytag
Scenario: Share a skill
	Given I have navigated to Service Listing page to add describe my skill
	And I have entered the details of my skill
	When I click on Save button
	Then my skill details will be saved
