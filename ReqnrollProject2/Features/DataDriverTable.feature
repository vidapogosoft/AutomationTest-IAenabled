Feature: DataDriverTable

A short summary of the feature

Scenario: Suma de dos numeros
	Given con lo siguientes numeros
	| dato1 | dato2 |
	| 50    | 50 |
	When realizar la sumatoria
	Then el resultado a validar debe ser 100


Scenario: Suma de dos numeros table
	Given con lo siguientes numeros de la tabla
	| dato1 | dato2 |
	| 50    | 50 |
	| 40    | 60 |
	| 80    | 20 |
	When realizar la sumatoria
	Then el resultado a validar debe ser 100