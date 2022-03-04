Feature: Search skill by subcategories
	
	I want to be search a skill by selected subcategories
	
@mytag
Scenario: Search a skill by Subcategories
	Given I have navigated to Search page
	And I select a subcategory
    When I select another subcategory
	Then the expected result should be displayed
