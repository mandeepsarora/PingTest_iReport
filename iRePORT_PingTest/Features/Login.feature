Feature: Login
Scenario: Logging into iRePORT
	Given I have navigated to the login screen
	And I enter the username and password
	When I click Login button
	Then I should see the dashboard
