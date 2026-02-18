Feature: LoginWeb

@tag1
Scenario Outline: Login Exitoso
	Given Usuario se dirige a website <rutaweb>
	When para ingresar digita su usuario <username> y contraseña <password>
	And realiza click sobre boton Login par ingresar
	Then login correcto en pagina <webhome>
	
	Examples:
	| rutaweb												 | username   | password | webhome                                          | 
	| https://admin-sysnnova.com/OpenFact/Account/Login.aspx | demo		  | 0430     | https://admin-sysnnova.com/OpenFact/Default.aspx |

Scenario Outline: Seleccion de Menu en Home
	Given Usuario se dirige al menu <menu>
	When para ingresar un nuevo cliente
	Then acceso correcto a la funcionalidad <func>
	
	Examples:
	| menu       | func	                                                            |
	| liClientes | https://admin-sysnnova.com/OpenFact/FastFactEmisor/frmCliente.aspx |

Scenario Outline: Registro
	Given Usuario se dirige al boton <boton>
	When comienzo el registro de datos de nombres <nombres>
	And  tipo de identificacion <tipoidentificacion>
	And  numero de identificacion <identificacion>
	And  telefono convencional <fono>
	And  direccion de contacto <direccion>
	And  correo electronico <email>
	Then click sobre el boton guardar
	
	Examples:
	| boton              | nombres         | tipoidentificacion | identificacion | fono      | direccion    | email               |
	| MainContent_btnAdd | VPR2-Agosto2023 | 05                 | 0959143928     | 045114999 | norte de gye | correo1@dominio.com |

Scenario: Logout
	When usuario realiza LogOut
	Then Salir de aplicacion
