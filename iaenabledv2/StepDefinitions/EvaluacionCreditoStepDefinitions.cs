using System;
using System.Linq;
using Reqnroll;
using EvaluacionCredito.Tests.Models;
using EvaluacionCredito.Tests.Services;
using Xunit;
using System.Globalization;

namespace EvaluacionCreditoTests.Features
{
    [Binding]
    public class EvaluacionCreditoStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private Customer _customer;
        private string _result;
        private string _securityAction;
        private string _securityResponse;
        private readonly CreditEvaluator _sut = new CreditEvaluator();

        public EvaluacionCreditoStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("el cliente tiene edad {int}")]
        public void GivenClienteEdad(int edad)
        {
            _customer = new Customer { Age = edad };
        }

        [Given("cumple con los demás criterios")]
        public void GivenCumpleDemasCriterios()
        {
            // otros campos quedan con valores por defecto
        }

        [When("solicita crédito")]
        public void WhenSolicitaCredito()
        {
            _result = _sut.EvaluateCredit(_customer);
        }

        [Then("el resultado esperado es (.*)")]
        public void ThenResultadoEsperadoEs(string esperado)
        {
            // normalize both for comparison
            string normalized_expected = NormalizeString(esperado.Trim());
            string normalized_actual = NormalizeString(_result);
            Assert.Equal(normalized_expected, normalized_actual);
        }

        [Given("el cliente tiene ingreso (.*)")]
        public void GivenClienteIngreso(string ingreso)
        {
            if (_customer == null)
                _customer = new Customer();
            _customer.Age = 25; // default age for income tests
            // normalize to remove accents and compare
            string normalized = ingreso.ToLowerInvariant();
            normalized = string.Concat(normalized.Normalize(System.Text.NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));

            if (normalized.Contains("limite minimo"))
            {
                _customer.Income = 1000m;
            }
            else if (normalized.Contains("menor al minimo"))
            {
                _customer.Income = 500m;
            }
            else
            {
                _customer.Income = 0m;
            }
        }

        [Given("el cliente tiene historial (.*)")]
        public void GivenClienteHistorial(string historial)
        {
            if (_customer == null)
                _customer = new Customer();
            _customer.Age = 25; // default age for history tests
            // normalize to remove accents and compare
            string normalized = historial.ToLowerInvariant();
            normalized = string.Concat(normalized.Normalize(System.Text.NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
            _customer.History = normalized;
        }

        [Given("el cliente tiene deuda (.*)")]
        public void GivenClienteDeuda(string deuda)
        {
            if (_customer == null)
                _customer = new Customer();
            _customer.Age = 25; // default age for debt tests
            // normalize to remove accents and compare
            string normalized = deuda.ToLowerInvariant();
            normalized = string.Concat(normalized.Normalize(System.Text.NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
            _customer.Debt = normalized;
        }

        [Given("el cliente realiza acci.n (.*)")]
        public void GivenClienteAccion(string accion)
        {
            // normalize to remove accents and compare
            string normalized = accion.ToLowerInvariant();
            normalized = string.Concat(normalized.Normalize(System.Text.NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
            _securityAction = normalized;
        }

        [When("se procesa la solicitud")]
        public void WhenSeProcesaLaSolicitud()
        {
            _securityResponse = _sut.ProcessSecurityAction(_securityAction);
        }

        [Then("el sistema responde con (.*)")]
        public void ThenSistemaResponde(string respuesta)
        {
            // normalize both for comparison
            string normalized_expected = NormalizeString(respuesta.Trim());
            string normalized_actual = NormalizeString(_securityResponse);
            Assert.Equal(normalized_expected, normalized_actual);
        }

        private string NormalizeString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            string normalized = input.ToLowerInvariant();
            normalized = System.Text.RegularExpressions.Regex.Replace(normalized, @"[áäàâ]", "a");
            normalized = System.Text.RegularExpressions.Regex.Replace(normalized, @"[éëèê]", "e");
            normalized = System.Text.RegularExpressions.Regex.Replace(normalized, @"[íïìî]", "i");
            normalized = System.Text.RegularExpressions.Regex.Replace(normalized, @"[óöòô]", "o");
            normalized = System.Text.RegularExpressions.Regex.Replace(normalized, @"[úüùû]", "u");
            return normalized;
        }
    }
}
