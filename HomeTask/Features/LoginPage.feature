Feature: LoginPage

A short summary of the feature
Background:
	Given user in the login page
 
@tag1
Scenario Outline: verify user can succesfully login to the system
	Given user enter <username> and <password>
	When user clicks on the login button
	Then user navigate to home page

Examples: 
	| Username      | Password     |
	| standard_user | secret_sauce |



