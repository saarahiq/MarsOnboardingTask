Feature: LanguageFeature

As a Mars website user
I would like to add, update and delete language on my profile details page
so that I can manage my languages on my profile successfully

@tag1
Scenario: Create a new Language in my Profile 
	Given I logged in successfully and I am in the Languages Tab
	When I click on Add New button and create a Language and Level
	Then The language should be added and I should see Notification 

	Scenario Outline: Edit an existing Language with valid details
		Given  I logged in successfully and I click on Edit button
		When I edit '<language>' and '<Level>'
		And I click on Update button
		Then The language should be updated and I should see '<Notification>'


Examples: 
| Language | Level  | Notification                              |
| Mandarin | Basic  | Mandarin has been added to your languages |
|		   | Fluent | French has been updated to your languages |
