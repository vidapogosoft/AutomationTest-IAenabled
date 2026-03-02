using EvaluacionCredito.Models;
using EvaluacionCredito.Services;
using Reqnroll;
using Xunit;

namespace EvaluacionCredito.StepDefinitions
{
    [Binding]
    public class EvaluacionCreditoStepDefinitions
    {
        private Customer _cliente;
        private string _resultado;
        private CreditEvaluator _evaluador;

        public EvaluacionCreditoStepDefinitions()
        {
            _cliente = new Customer();
            _evaluador = new CreditEvaluator();
        }

        [Given(@"el cliente tiene edad (\d+)")]
        public void GivenElClienteTieneEdad(int edad)
        {
            _cliente.Age = edad;
        }

        [Given(@"cumple con los demás criterios")]
        public void GivenCumpleConLosDemasCriterios()
        {
            // placeholder - no-op, defaults assumed valid
        }

        [Given(@"el cliente tiene ingreso (.*)")]
        public void GivenElClienteTieneIngreso(string ingreso)
        {
            _cliente.Income = ingreso;
        }

        [Given(@"el cliente tiene historial (.*)")]
        public void GivenElClienteTieneHistorial(string historial)
        {
            _cliente.History = historial;
        }

        [Given(@"el cliente tiene deuda (.*)")]
        public void GivenElClienteTieneDeuda(string deuda)
        {
            _cliente.Debt = deuda;
        }

        [Given(@"el cliente realiza acción (.*)")]
        public void GivenElClienteRealizaAccion(string accion)
        {
            _cliente.SecurityAction = accion;
        }

        [When(@"solicita crédito")]
        public void WhenSolicitaCredito()
        {
            _resultado = _evaluador.Evaluate(_cliente);
        }

        [When(@"se procesa la solicitud")]
        public void WhenSeProcesaLaSolicitud()
        {
            _resultado = _evaluador.ProcessSecurity(_cliente.SecurityAction);
        }

        [Then(@"el resultado esperado es (.*)")]
        public void ThenElResultadoEsperadoEs(string esperado)
        {
            Assert.Equal(esperado, _resultado);
        }

        [Then(@"el sistema responde con (.*)")]
        public void ThenElSistemaRespondeCon(string esperado)
        {
            Assert.Equal(esperado, _resultado);
        }
    }
}