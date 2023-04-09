Feature: SkillsFeature

As a Mars website user, I want to add, update and delete a skill in my profile details
so that I can manage skills on my profile successfully

@tag1
Scenario: Create a new Skill in my Profile 
	Given I logged in successfully and navigated to Skills Tab
	When I click on Add New button and add a Skill and Level
	Then The Skill should be added and I should see Notification 

	Scenario Outline: Edit an existing Skill with valid details
		Given  I logged in successfully and I click on Edit button in Skills
		When I edit '<Skill>' and '<Level>' in Skills Tab
		And I click on Update button in Skills Tab
		Then The Skill should be updated and I should see '<Notification>'

		
Examples: 
| Skill		 | Level         | Notification                              |
| Javascript | Intermediate  | Javascript has been updated to your skill |