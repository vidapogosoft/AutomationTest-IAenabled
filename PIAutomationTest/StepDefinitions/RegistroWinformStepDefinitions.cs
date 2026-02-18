using System;
using TechTalk.SpecFlow;

using PIAutomationTest.Drivers.dto;
using TechTalk.SpecFlow.Assist;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using SpecFlow.Actions.WindowsAppDriver;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class RegistroWinformStepDefinitions
    {

        //private readonly WindowsDriver<WindowsElement> _driver;
        private readonly AppDriver _appDriver;

        public RegistroWinformStepDefinitions(AppDriver appDriver)
        {
            _appDriver = appDriver;
        }

        [Given(@"usuario se dirige a aplicativo winform de registro")]
        public void GivenUsuarioSeDirigeAAplicativoWinformDeRegistro()
        {

            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", "D:\\vidapogosoft\\cursos\\2023\\SIPECOM\\TestAutomatizadosFCME\\herramientas\\AppWinForm1.exe");
            options.AddAdditionalCapability("deviceName", "PORTUGALASUS");

            _appDriver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [When(@"llena formulario con los siguientes datos")]
        public void WhenLlenaFormularioConLosSiguientesDatos(Table table)
        {
            var LisRegistro = table.CreateSet<Registro>();

            foreach (var data in LisRegistro)
            {
                //TODO
                //data.nombres;

                _appDriver.Current.FindElementByAccessibilityId("TxtIdentificacion").Click();
                _appDriver.Current.FindElementByAccessibilityId("TxtIdentificacion").SendKeys(data.identificacion);

                _appDriver.Current.FindElementByAccessibilityId("TxtNombres").Click();
                _appDriver.Current.FindElementByAccessibilityId("TxtNombres").SendKeys(data.nombres);


                _appDriver.Current.FindElementByAccessibilityId("TxtDireccion").Click();
                _appDriver.Current.FindElementByAccessibilityId("TxtDireccion").SendKeys(data.direccion);

                _appDriver.Current.FindElementByName("Confirmar Datos").Click();
            }
        }

        [When(@"visualizo datos registrados")]
        public void WhenRealizaClickEnBotonRegistrar()
        {
            throw new PendingStepException();
        }

        [Then(@"registro correcto")]
        public void ThenRegistroCorrecto()
        {
            throw new PendingStepException();
        }
    }
}
