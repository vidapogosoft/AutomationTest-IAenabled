using EvaluacionCredito.Services;
using Reqnroll;
using Xunit;

namespace EvaluacionCredito.StepDefinitions
{
    [Binding]
    public class PagoElectronicoStepDefinitions
    {
        private string _tarjeta;
        private bool _issuerAuthorized;
        private string _registro;
        private bool _comprobanteEmitido;
        private readonly PaymentService _paymentService;

        public PagoElectronicoStepDefinitions()
        {
            _paymentService = new PaymentService();
        }

        [Given("que estoy autenticado en el sistema de caja")]
        public void GivenEstoyAutenticadoEnElSistemaDeCaja()
        {
            // asumimos autenticación válida
        }

        [Given("tengo una venta lista para cobrar en el PinPad")]
        public void GivenTengoUnaVentaListaParaCobrarEnElPinPad()
        {
            // placeholder: nada que preparar para el servicio
        }

        [When("intento cobrar con la (.*)")]
        public void WhenIntentoCobrarConLaTarjeta(string tarjeta)
        {
            _tarjeta = tarjeta;
        }

        [When("el emisor autoriza la transacción")]
        public void WhenElEmisorAutorizaLaTransaccion()
        {
            _issuerAuthorized = true;
            _registro = _paymentService.Process(_tarjeta, _issuerAuthorized, out _comprobanteEmitido);
        }

        [When("el emisor rechaza la transacción")]
        public void WhenElEmisorRechazaLaTransaccion()
        {
            _issuerAuthorized = false;
            _registro = _paymentService.Process(_tarjeta, _issuerAuthorized, out _comprobanteEmitido);
        }

        [Then("el pago debe registrarse como \"(.*)\"")]
        public void ThenElPagoDebeRegistrarseComo(string esperado)
        {
            Assert.Equal(esperado, _registro);
        }

        [Then("se debe emitir el comprobante con la tarjeta utilizada")]
        public void ThenSeDebeEmitirElComprobanteConLaTarjetaUtilizada()
        {
            Assert.True(_comprobanteEmitido);
        }

        [Then("no se debe emitir comprobante")]
        public void ThenNoSeDebeEmitirComprobante()
        {
            Assert.False(_comprobanteEmitido);
        }
    }
}