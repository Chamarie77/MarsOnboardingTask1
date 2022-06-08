Feature: EducationFeatureFile

As a localhost:5000 portal admin
I would like to add more details to my profile and view them
So, I can manage profile file successfully.

Scenario: add a Education details to Profile file 
	Given I logged into turnup portal successfully 
	When I add details in  Education
	Then the new Education details should be saved successfully

Scenario: edit a Education details on Profile file 
	Given I logged into turnup portal successfully 
	When I update details in  Education
	Then the Education details should be updated successfully

Scenario: delete a Education details from Profile file 
	Given I logged into turnup portal successfully 
	When I delete details in  Education
	Then the Education details should be deleted successfully
