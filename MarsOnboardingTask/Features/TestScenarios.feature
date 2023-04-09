Feature: TestScenarios


@tag1
Scenario: Sign Up on Mars website
	Given I click on Join button and Sign up with valid details
	When I click on Join button
	Then I should have created a Mars website account successfully

Scenario: Login into Mars website
	Given I click on Sign In button and login with valid details
	When I click on Login button
	Then I should have logged in successfully 

Scenario: I add Description on my profile
	Given I logged in successfully and navigate to Description tab
	When I add my description and click save
	Then The description should be successfully added

	Scenario Outline: Edit Description on my profile
		Given  I logged in successfully and I click on Edit button in Description
		When I edit description
		And I click on Save button
		Then The description should be updated and I should see the Notification

Scenario: I add Certification on my profile 
	Given I logged in successfully and navigate to Certification tab
	When I add certification details and click Add
	Then The certification should be successfully added 

	Scenario Outline: Edit an existing Certification with valid details
		Given  I logged in successfully and I click on Edit button in Certification
		When I edit certification details 
		And I click on the Update button 
		Then The Certification should be updated and I should see the Notification

Scenario: I add Availability on my profile
	Given I logged in successfully 
	When I click on Availability edit button and select availability type
	Then The availability type should be added and successfully displayed 

	Scenario Outline: Edit Availability on my profile
		Given  I logged in successfully and I click on Edit button in Availability
		When I edit availability type 
		Then The new Availability should be updated and I should see the Notification

Scenario: I add Hours on my profile
	Given I logged in successfully 
	When I click on Hours edit button and select relevant working hours
	Then The Hours should be added and succesfully displayed 

	Scenario Outline: Edit Hours on my profile
		Given  I logged in successfully and I click on Edit button in Hours
		When I edit hours type 
		Then The new Hours should be updated and I should see the Notification

Scenario: I add Earn Target on my profile
	Given I logged in successfully 
	When I click on Earn Target edit button and select relevant target type
	Then The Earn Target should be added and succesfully displayed 

	Scenario Outline: Edit Earn Target on my profile
		Given  I logged in successfully and I click on Edit button in Earn Target
		When I edit earn target range
		Then The new Earn Target should be updated and I should see the Notification

Scenario: I Sign Out of Mars website
	Given I logged in successfully
	When I click on Sign Out button
	Then I should have successfully logged out


