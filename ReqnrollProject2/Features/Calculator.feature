Feature: Calculator

Simple calculator for adding two numbers


Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Add 3 numbers
	Given the first number is 50
	And the second number is 70
	And the third number is 30
	When the three numbers are added
	Then the result should be 150