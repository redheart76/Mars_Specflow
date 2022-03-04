Feature: Delete Listed Skills
	
	I want to delete my skill in my skill listings
	
@mytag
Scenario: Delete a listed skill
	Given I have navigated to Listing Management Page
	And I click on the Delete icon of the selected skill
    When I click on Yes to accept the deletion
	Then the selected skill will be deleted

