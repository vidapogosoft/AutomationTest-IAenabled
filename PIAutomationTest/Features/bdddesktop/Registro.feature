Feature: Registro winform

A short summary of the feature

@tag1
Scenario: Registro de datos en winform
	Given usuario se dirige a aplicativo winform de registro
	When llena formulario con los siguientes datos
	| identificacion | nombres | direccion | estadocivil |
	| 0919172551 | victor portugal | norte de gye | casado |
	| 0919172561 | jhon wick | norte de gye | viudo |
	And visualizo datos registrados
	Then registro correcto
