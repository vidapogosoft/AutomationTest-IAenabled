Feature: Saldos en Cuenta

A short summary of the feature

@tag1
Scenario: Debito de Cuenta con monto valido actualiza saldo
	Given Mi saldo inicial de dolares en cuenta es de 40
	When Se debita un monto en dolares de 10
	Then Saldo actual en cuenta de 30 

Scenario: Debito de Cuenta con monto invalido no actualiza saldo
	Given Mi saldo inicial de dolares en cuenta es de 100
	When Se debita un monto en dolares de 120
	Then Saldo actual en cuenta de 100

Scenario: Debito de Cuenta con monto negativo no actualiza saldo
	Given Mi saldo inicial de dolares en cuenta es de 100
	When Se debita un monto en dolares negativo de -20
	Then Saldo actual en cuenta de 100

Scenario: Credito en Cuenta con monto valido actualiza saldo
	Given Mi saldo inicial de dolares en cuenta es de 40
	When Se acredita un monto en dolares de 10
	Then Saldo actual en cuenta de 50 