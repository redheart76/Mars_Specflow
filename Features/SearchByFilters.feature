Feature: Search skill by filters
	
	I want to be search a skill by selected filter
	
@mytag
Scenario: Search skill by name as a filter
	Given I have clicked on Search and navigated to Search page
	When I enter a user's name as the search filter
	Then the expected user should be displayed