Feature: Calculator

Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120


Scenario: Add two numbers v2
	Given the first number is 40
	And the second number is 60
	When the two numbers are added
	Then the result should be 100


Scenario: Add two numbers v3
	Given el primer numero es 100
	And el segundo numero es 100
	When los dos numeros deben ser restados
	Then el resultado debe ser 0
