Feature: Chat History
	In order to chat with other users
	I want to view the chat history
	
@mytag
Scenario: Check Chat history
	Given I have navigated to the Message Page
	When I click on the person who I want to chat with
	Then the chat history will be displayed
