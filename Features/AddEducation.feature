Feature: Add a new education
	
	I want to add my education details to my profile


	
@mytag
Scenario: Add my education details
	Given I click on Education tab
	And I click on Add New button
	And I enter my education details
    When I click Add button
	Then my education has been saved
