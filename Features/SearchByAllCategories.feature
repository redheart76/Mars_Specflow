Feature: Search skills by all categories
	
	I want to search skills for trade by all categories
	
@mytag
Scenario: Search skills by all categories
	Given I have navigated to Home page
    And I enter the Search Condition
	When I click on Search skill button
	Then the result will be displayed
