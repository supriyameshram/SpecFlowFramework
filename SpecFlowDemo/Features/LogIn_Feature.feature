Feature: LogIn_Feature
In order to access my account
	As a user of the website
	I want to log into the website

@mytag
Scenario: Successful Login with Valid Credentials
 Given User is on LogIn Page
 When User enter credentials
 | Key      | Value  |
 | Username | mgr123 |
 | Password | mgr!23 |
 And Click on LogIn button
 Then Successful LogIn message should display
 When User Click on LogOut button
 Then Successful Logout message should display
 