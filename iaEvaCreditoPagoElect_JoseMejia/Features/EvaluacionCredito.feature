Feature: Evaluación de crédito con datos parametrizados

  Scenario Outline: Validación de edad del cliente
    Given el cliente tiene edad <Edad>
    And cumple con los demás criterios
    When solicita crédito
    Then el resultado esperado es <Resultado>

    Examples:
      | Edad | Resultado              |
      | 18   | Crédito asignado       |
      | 70   | Crédito asignado       |
      | 17   | Crédito rechazado      |

  Scenario Outline: Validación de ingresos
    Given el cliente tiene ingreso <Ingreso>
    When solicita crédito
    Then el resultado esperado es <Resultado>

    Examples:
      | Ingreso        | Resultado         |
      | límite mínimo  | Crédito aprobado  |
      | menor al mínimo| Crédito rechazado |

  Scenario Outline: Validación de historial crediticio
    Given el cliente tiene historial <Historial>
    When solicita crédito
    Then el resultado esperado es <Resultado>

    Examples:
      | Historial              | Resultado                     |
      | vacío                  | Evaluación especial / limitado|
      | negativo (morosidad)   | Crédito rechazado             |

  Scenario Outline: Validación de deuda
    Given el cliente tiene deuda <Deuda>
    When solicita crédito
    Then el resultado esperado es <Resultado>

    Examples:
      | Deuda   | Resultado                     |
      | límite  | Crédito aprobado con condiciones |

  Scenario Outline: Validación de seguridad del sistema
    Given el cliente realiza acción <Acción>
    When se procesa la solicitud
    Then el sistema responde con <Respuesta>

    Examples:
      | Acción                          | Respuesta                        |
      | "' OR '1'='1"                   | Bloqueo entrada / error controlado|
      | Acceso sin rol analista         | Acceso denegado                  |
      | Alteración de payload           | Datos rechazados / alerta        |
      | Alteración de score en front-end| Validación backend evita fraude  |
      | Fuerza bruta en login           | Cuenta bloqueada / alerta        |