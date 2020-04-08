Feature: MVPLogin
	In order to update profile on MVP Portal
	As a user
	I want to login successfully to update my profile

@scopedBinding
Scenario: Open MVP website and should navigate to login page
Given I have navigated to MVP Portal website
And I have entered username
And I have entered password
When I press the signin button
Then I should be able navigate to MVP Portal

