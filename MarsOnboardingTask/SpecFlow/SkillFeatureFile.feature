Feature: FeatureFileSkill

As a localhost:5000 portal admin
I would like to add more details to my profile and view them
So, I can manage profile file successfully.

Scenario: add a skills details to Profile file 
	Given I logged into turnup portal successfully 
	When I add details in  Skills
	Then the new Skills details should be saved successfully

Scenario: edit a skills details to Profile file 
	Given I logged into turnup portal successfully 
	When I update details in  Skills
	Then the Skills details should be updated successfully

Scenario: delete a skills details to Profile file 
	Given I logged into turnup portal successfully 
	When I delete details in  Skills
	Then the Skills details should be deleted successfully

