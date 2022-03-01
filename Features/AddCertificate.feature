Feature: Add new certificate
	
	I want add a new cetificate to my profile of certification 
	
@mytag
Scenario: Add a new certificate
	Given I have navigated to the certification section
    And I click on Add New cert button
	And I have entered my new cetifecate details
	When I click on Add button to add a new certificate
	Then the new cetificate will be saved
