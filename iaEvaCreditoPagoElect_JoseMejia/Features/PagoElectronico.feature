# language: es

Característica: Pago electrónico (PinPad)
  Como cajero del sistema de cobros
  Quiero procesar pagos con tarjeta en el PinPad
  Para registrar pagos aprobados y manejar rechazos correctamente

  Antecedentes:
    Dado que estoy autenticado en el sistema de caja
    Y tengo una venta lista para cobrar en el PinPad

  Esquema del escenario: CU5 - Pago aprobado
    Cuando intento cobrar con la <Tarjeta>
    Y el emisor autoriza la transacción
    Entonces el pago debe registrarse como "aprobado"
    Y se debe emitir el comprobante con la tarjeta utilizada

    Ejemplos:
      | Tarjeta          |
      | Tarjeta Credito |
      | Tarjeta Debito  |

  Esquema del escenario: CU5 - Pago no aprobado
    Cuando intento cobrar con la <Tarjeta>
    Y el emisor rechaza la transacción
    Entonces el pago debe registrarse como "no aprobado"
    Y no se debe emitir comprobante

    Ejemplos:
      | Tarjeta          |
      | Tarjeta Credito |
      | Tarjeta Debito  |