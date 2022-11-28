Feature: LoginPage

A short summary of the feature

@tag1
Scenario: verify user can succesfully login to the system]
	Given user in the login page
	When user enter username and password
		| Username      | Password     |
		| standard_user | secret_sauce |
	When user clicks on the login button
	Then user navigate to home page



