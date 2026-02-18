Feature: LoginMovil

A short summary of the feature

@tag1
Scenario: Registro de datos en app correcto
	Given usuario se dirige a app de registro
	When llena formulario con los siguientes datos en lista
	| codigo | descripcion | precio |
	| 1      | Producto 1  | 100 |
	| 2      | Producto 2  | 200 |
	| 3      | Producto 3  | 300 |
	And visualiza resultado de la lista
	Then registro correcto de la lista

Scenario Outline: Registro de datos en app valido resultado
	Given usuario se dirige a app de registro
	When llena formulario con los siguientes datos <codigo>, <descripcion>, <precio>
	And realiza click en boton save
	Then registro correcto esperando <codigo>-<descripcion>
	Examples: 
	| codigo | descripcion  | precio |
	| 500    | Producto 500 | 120    |