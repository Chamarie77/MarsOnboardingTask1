Feature: SellerAddProfileDetails

As a localhost:5000 portal admin
I would like to add more details to my profile and view them
So, I can manage profile file successfully.



Scenario: create profile file with valid details
	Given I logged into localhost:5000/Home successfully 
	When I navigate to Profile Page
	When I create a new profile 
	Then Then the file should be created successfully

Scenario Outline: edit profile file with valid details
	Given I logged into localhost:5000/Home successfully 
	When I navigate to Profile Page
	When I update '<Languages>', '<Skills>' and '<Certifications>' on an existing Profile File
	Then  the Profile file s hould have the updated '<Languages>', '<Skills>' and '<Certifications>'

	Examples:
	| Languages | Skills    | Certifications |
	| Sinhalese | SpecFlow  | Java           |
	| English   | C#        | ISTQB          |
	| Sign      | Sellenium | Microsoft      |
