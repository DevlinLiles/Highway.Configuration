Feature: GettingAndViewingSettings
	In order to find and use settings
	As an application developer
	I want to view all settings for my applications in an admin view

@mytag
Scenario: View Applications from System
	Given I have a windows account that is allowed to view settings
	When I go to the settings site
	Then I see the applications in the system I have view permissions on

Scenario: View Settings for application in system
	Given I have a windows account that is allowed to view settings
	And I have an application in the system with settings
	When I view that applications settings
	Then I see the settings for that application based on environment

Scenario: Edit Setting from System
	Given I have a windows account that is allowed to edit settings
	When I submit an edit for a setting
	Then I see the settings are updated
	And I see the new settings in the index view

Scenario: Unauthorized Edit
	Given I have a windows account that is not allowed to edit settings but is allowed to view them
	When I submit an edit for a setting
	Then I see the index screen with a message indicating that the edit is not allowed.

Scenario: View Settings for a restricted set of environments No Prod
	Given I have a windows account that is only allowed to view settings from QA and Development
	When I go to the settings site
	Then I see settings in the system for my applications
	And I do not see settings other than Dev and QA

Scenario: View Settings for a restricted set of enviroments Only Prod
	Given I have a windows account that is only allowed view settings from Production
	When I go to the settings site
	Then I see settings in the system from my applications
	And I do not see settings other than production

Scenario: View Setings for multiple applications
	Given I have a windows account that is allowed to view settings for multiple applications
	When I go to the settings site
	Then I see all applications in the system I have view permissions on



