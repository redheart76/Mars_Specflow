Feature: View Received Request
	
	I want to view the requests that I have received
	
@mytag
Scenario: Recieved Request
	Given I have navigated to profile page and hove the mouse on Received Request tab
	When I click on the Received Request from the drop down menu
	Then I can see the request in the Received Requests page
