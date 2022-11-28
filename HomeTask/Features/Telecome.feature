Feature: TelecomePage

A short summary of the feature

@tag1
Scenario: verify user can succefuly register]
	Given user in the telecome page
	When user tick radion button
	When user enter firstname, lastname,email, address and mobilenumber
		| firstname      |lastname     |email          |address     |mobilenumber     | 
		| test           |user         |test@gmail.com |TestVillage |0911111111       | 
	When user clicks on the submit button
	Then user navigate to access_detail page
