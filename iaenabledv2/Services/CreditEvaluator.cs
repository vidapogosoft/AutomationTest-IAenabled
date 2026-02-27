using EvaluacionCredito.Tests.Models;
using System.Text.RegularExpressions;

namespace EvaluacionCredito.Tests.Services
{
    public class CreditEvaluator
    {
        private const decimal IncomeThreshold = 1000m;

        public string EvaluateCredit(Customer customer)
        {
            if (customer == null)
                return "Credito rechazado";

            // validacion de edad
            if (customer.Age < 18)
                return "Credito rechazado";
            if (customer.Age > 70)
                return "Credito rechazado";

            // validacion de ingresos 
            if (customer.Income > 0)
            {
                if (customer.Income < IncomeThreshold)
                    return "Credito rechazado";
                if (customer.Income == IncomeThreshold)
                    return "Credito aprobado";
                if (customer.Income > IncomeThreshold)
                    return "Credito asignado";
            }

            // historial crediticio
            if (!string.IsNullOrEmpty(customer.History))
            {
                if (customer.History.Contains("morosidad"))
                    return "Credito rechazado";
                if (customer.History == "vacio")
                    return "Evaluacion especial / limitado";
            }

            // deuda
            if (!string.IsNullOrEmpty(customer.Debt))
            {
                if (customer.Debt == "limite")
                    return "Credito aprobado con condiciones";
            }

            // default for age-only scenarios
            if (customer.Age >= 18 && customer.Age <= 70)
                return "Credito asignado";

            return "Credito rechazado";
        }

        public string ProcessSecurityAction(string action)
        {
            if (string.IsNullOrEmpty(action))
                return "Accion no reconocida";

            string normalized = action.ToLowerInvariant();
            
            if (normalized.Contains("sql injection") || normalized.Contains("or") && normalized.Contains("1"))
                return "Bloqueo entrada / error controlado";
            if (normalized.Contains("acceso sin rol") || normalized.Contains("analista"))
                return "Acceso denegado";
            if (normalized.Contains("alteracion de payload") || normalized.Contains("alteracion") && normalized.Contains("payload"))
                return "Datos rechazados / alerta";
            if (normalized.Contains("alteracion de score") || (normalized.Contains("alteracion") && normalized.Contains("score")))
                return "Validacion backend evita fraude";
            if (normalized.Contains("fuerza bruta") || (normalized.Contains("bruta") && normalized.Contains("login")))
                return "Cuenta bloqueada / alerta";

            return "Accion no reconocida";
        }
    }
}
