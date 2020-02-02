Feature: Calculation
	As a user
	In order to get results quickly
	I want to be told the calculated result of two numbers

@mytag
Scenario: Add two numbers
	When I enter <numberOne> into the calculator
	And I press the add button
	And I enter <numberTwo> into the calculator
	And I press the calculate button
	Then the result should be <result> on the screen
Examples: 
	| numberOne | numberTwo | result |
	| 12        | 34        | 46     |
	| 56        | 78        | 134    |
	| 90        | 12        | 102    |
	| 69        | 42        | 111    |
	| 27        | 45        | 72     |
