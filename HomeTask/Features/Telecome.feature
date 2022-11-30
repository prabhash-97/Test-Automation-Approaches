Feature: TelecomePage

A short summary of the feature
Background:
	Given user in the telecome page

@tag1
Scenario Outline: verify user can succefuly register]
	When user tick radion button
	Given new user enter firstname, lastname, email, address and mobilenumber
		| firstname      |lastname     |email          |address     |mobilenumber     | 
		| test           |user         |test@gmail.com |TestVillage |0911111111       | 
	When user clicks on the submit button
	Then user navigate to access_detail page
