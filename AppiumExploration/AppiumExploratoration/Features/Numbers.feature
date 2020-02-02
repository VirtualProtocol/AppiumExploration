Feature: Numbers
	As a user
	In order to view the digits I have entered
	I want the digits I have entered to be displayed

@mytag
Scenario: Display Numbers
	When I enter <numberOne> into the calculator
	Then the result should be <numberTwo> on the screen
Examples: 
	| numberOne | numberTwo |
	| 1         | 1         |
	| 2         | 2         |
	| 3         | 3         |
	| 4         | 4         |
	| 5         | 5         |
	| 6         | 6         |
	| 7         | 7         |
	| 8         | 8         |
	| 9         | 9         |
	| 0         | 0         |
