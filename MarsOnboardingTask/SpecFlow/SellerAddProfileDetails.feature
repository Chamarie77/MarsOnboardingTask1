Feature: SellerAddProfileDetails

As a localhost:5000 portal admin
I would like to add more details to my profile and view them
So, I can manage profile file successfully.



Scenario: create profile file with valid details
	Given I logged into localhost:5000/Home successfully 
	When I navigate to Profile Page
	When I create a new record for Language
	Then Then the new record should be created successfully

Scenario Outline: edit profile file with valid details
	Given I logged into localhost:5000/Home successfully 
	When I navigate to Profile Page
	When I update '<Languages>' on existing Profile File
	Then  the record should have the updated '<Languages>'

	Examples:
	| Languages |
	| Japanese  |
	| Sign      |
	 
