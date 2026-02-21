Feature: LoginWeb

A short summary of the feature

@tag1
Scenario Outline: Login Exitoso
	Given usuario se dirige a website <rutaweb>
	When para ingresar digita su usuario <username> y password <password>
	And  realiza click sobre boton login para ingresar
	Then login correctro en pagina <webhome>

	Examples:
	| rutaweb												| username  | password | webhome |
	| https://cpanel-safety.com/openfact/Account/Login.aspx | demo	    | 0430     |  https://cpanel-safety.com/openfact/Default.aspx  |


Scenario Outline: Seleccion de menu en home
	Given usuario se dirige al menu <menu>
	When para ingresar un nuevo cliente
	Then acceso correcto a la funcionalidad <func>

	Examples:
	| menu       | func  |
	| liClientes | https://cpanel-safety.com/OpenFact/FastFactEmisor/frmCliente.aspx |

