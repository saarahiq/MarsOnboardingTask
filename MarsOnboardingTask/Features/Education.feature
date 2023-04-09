Feature: EducationFeature

A short summaryAs a Mars website user, I want to add, edit and delete Education in my profile
so that I can manage my profile details successfully

@tag1
Scenario: 01) Add education in Profile details
	Given I logged in successfully and navigate to Education Tab
	When I click on Add New button and add Education details
	Then The Education details should be added and I should see Notification

	Scenario Outline: 02) Edit an existing Education record with valid details
		Given I logged in successfully and navigate to Education Tab to edit
		When I edit '<University Name>', '<Country>', '<Title>', '<Degree>', '<Graduation Year>' in Education Tab
		Then The Education details should be updated with '<University Name>', '<Country>', '<Title>', '<Degree>', '<Graduation Year>' and I should see '<Notification>'
	
		Examples: 
		| University Name | Country     | Title | Degree       | Graduation Year | Notification                       |
		| Massey          | Australia   | PHD   | Food Science | 2021            | Education as been updated          |
		|                 | New Zealand | B.Sc  | Food Science | 2017            | Please enter all the fields        |
		| Massey          | Australia   | PHD   | Food Science | 2021            | This information is already exist. |

	Scenario Outline: 03) Delete an existing Education record in Profile details
		Given I click on the Delete button
		Then The Education details should be deleted and I should see '<Notification>'

		Examples: 
		| University Name | Country     | Title | Degree        | Graduation Year | Notification                         |
		| Massey          | Australia | PHD   | Foood Science | 2021            | Education enrty successfully removed |
		