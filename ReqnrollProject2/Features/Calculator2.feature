Feature: Calculator2

A short summary of the feature

Scenario: Suma de dos numeros
	Given el primer numero es 40
	And el segundo numero es 60
	When los dos numeros seran sumados
	Then el resultado debe ser 100

Scenario: Suma de tres numeros
	Given el primer numero es 30
	And el segundo numero es 40
	And el tercero numero es 20
	When los tres numeros seran sumados
	Then el resultado debe ser 90
