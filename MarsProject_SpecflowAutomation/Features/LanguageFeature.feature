Feature: This test suite contains scenarios for Profile Page Language feature


Scenario Outline: B. Add new Language
	Given user logs in to the Mars Portal
	And user navigates to Profile Page
	And user selects the Langauge Tab 'language'
	When user adds a new Language record <Language> <Level>
	Then Mars portal should save the new Language record <Language>

	Examples: 
	| Language	  | Level            |
	| 'Hindi'     | 'Basic'          |
	| 'Tamil'     | 'Conversational' |
	| 'English'   | 'Fluent'         |
	| 'Malayalam' | 'Native'         |

	Scenario Outline: C. Edit an Existing Language
	Given user logs in to the Mars Portal
	And user navigates to Profile Page
	And user selects the Langauge Tab 'language'
	When user edits an existing Language record <OldLanguage> <OldLevel> <NewLanguage> <NewLevel>
	Then Mars portal should save the updated Language record <NewLanguage> <NewLevel>
	
	Examples: 
	| OldLanguage | OldLevel         | NewLanguage | NewLevel         |
	| 'Hindi'     | 'Basic'          | 'German'    | 'Conversational' |
	| 'Tamil'     | 'Conversational' | 'Tamil'     | 'Basic'          |
	| 'English'   | 'Fluent'         | 'Spanish'   | 'Fluent'         |

	Scenario Outline: A. Delete an Existing Language
	Given user logs in to the Mars Portal
	And user navigates to Profile Page
	And user selects the Langauge Tab 'language'
	When user deletes an existing Language record <Language> <Level>
	Then Mars portal should delete the Language record <Language> <Level>
	
	Examples: 
	|  Language		| Level						|
	| 'Tamil'		| 'Basic'					|
	| 'Malayalam'   | 'Native/Bilingual'        |
	| 'German'		| 'Conversational'			|
	| 'Spanish'		| 'Fluent'					|