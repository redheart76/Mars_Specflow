Feature: Add new language
	
	I want to add a new language to my profile
	
@mytag
Scenario: Add a new language
	Given I have click on Add New
	And I have entered a new language
    And I have selected the language level
	When I press add
	Then the new language has been added
