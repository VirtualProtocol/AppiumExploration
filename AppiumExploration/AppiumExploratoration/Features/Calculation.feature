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

Scenario: Subtract two numbers
	When I enter <numberOne> into the calculator
	And I press the subtract button
	And I enter <numberTwo> into the calculator
	And I press the calculate button
	Then the result should be <result> on the screen
Examples:
	| numberOne | numberTwo | result |
	| 59        | 35        | 24     |
	| 96        | 50        | 46     |
	| 13        | 32        | -19    |
	| 79        | 70        | 9      |
	| 3         | 14        | -11    |

Scenario: Multiply two numbers
	When I enter <numberOne> into the calculator
	And I press the multiply button
	And I enter <numberTwo> into the calculator
	And I press the calculate button
	Then the result should be <result> on the screen
Examples: 
	| numberOne | numberTwo | result |
	| 64        | 7         | 448    |
	| 17        | 37        | 629    |
	| 21        | 1         | 21     |
	| 92        | 97        | 8924   |
	| 16        | 58        | 928    |

Scenario: Divide two numbers
	When I enter <numberOne> into the calculator
	And I press the divide button
	And I enter <numberTwo> into the calculator
	And I press the calculate button
	Then the result should be <result> on the screen
Examples: 
	| numberOne | numberTwo | result        |
	| 80        | 33        | 2.4242424242  |
	| 50        | 44        | 1.1363636364  |
	| 61        | 3         | 20.3333333333 |
	| 59        | 18        | 3.2777777778  |
	| 95        | 19        | 5             |