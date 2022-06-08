Feature: CertificationsFeatureFile

As a localhost:5000 portal admin
I would like to add more details to my profile and view them
So, I can manage profile file successfully.

Scenario: add a Certifications details to Profile file 
	Given I logged into turnup portal successfully 
	When I add details in  Certifications
	Then the new Certifications details should be saved successfully

Scenario: edit a Certifications details on Profile file 
	Given I logged into turnup portal successfully 
	When I update details in  Certifications
	Then the Certifications details should be updated successfully

Scenario: delete a Certifications details from Profile file 
	Given I logged into turnup portal successfully 
	When I delete details in  Certifications
	Then the Certifications details should be deleted successfully
