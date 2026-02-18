using PIAutomationTest.Drivers.dto;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using SpecFlow.Actions.Android.Driver;
using OpenQA.Selenium.Appium;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class LoginMovilStepDefinitions
    {

        //crear la instancia para el appium driver

        private readonly AndroidAppDriver _androidAppDriver;

        public LoginMovilStepDefinitions(AndroidAppDriver androidAppDriver)
        {
            _androidAppDriver = androidAppDriver;
        }


        [Given(@"usuario se dirige a app de registro")]
        public void GivenUsuarioSeDirigeAAppDeRegistro()
        {
           
            AppiumOptions cap = new AppiumOptions();

            cap.AddAdditionalCapability("app", "D:\\vidapogosoft\\cursos\\2023\\SIPECOM\\TestAutomatizadosFCME\\herramientas\\CrudContact\\app-release.apk");
            cap.AddAdditionalCapability("device", "SM-T295");
            cap.AddAdditionalCapability("deviceName", "Tab VPR");
            cap.AddAdditionalCapability("platformName", "Android");

        }

        [When(@"llena formulario con los siguientes datos en lista")]
        public void WhenLlenaFormularioConLosSiguientesDatosEnLista(Table table)
        {
            var ListRegistroApp = table.CreateSet<RegistroApp>();

            foreach (var data in ListRegistroApp)
            {
                //TODO
                //data.codigo;

                //Cajas de texto
                AndroidElement TxtId = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/TxtCodigo");
                TxtId.SendKeys(data.codigo);

                AndroidElement TxtDescripcion = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/TxtDescripcion");
                TxtDescripcion.SendKeys(data.descripcion);

                AndroidElement TxtPrecio = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/TxtPrecio");
                TxtPrecio.SendKeys(data.precio);

                ///Boton
                AndroidElement BtnSave = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/BtnSave");
                BtnSave.Click();
            }
        }

        [When(@"visualiza resultado de la lista")]
        public void WhenRealizaClickEnBotonSaveLista()
        {
            throw new PendingStepException();
        }

        [When(@"llena formulario con los siguientes datos (.*), (.*), (.*)")]
        public void WhenLlenaFormularioConLosSiguientesDatos(string codigo, string descripcion, string precio)
        {
            //Cajas de texto
            AndroidElement TxtId = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/TxtCodigo");
            TxtId.SendKeys(codigo);

            AndroidElement TxtDescripcion = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/TxtDescripcion");
            TxtDescripcion.SendKeys(descripcion);

            AndroidElement TxtPrecio = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/TxtPrecio");
            TxtPrecio.SendKeys(precio);
        }

        [When(@"realiza click en boton save")]
        public void WhenRealizaClickEnBotonSave()
        {
            ///Boton
            AndroidElement BtnSave = _androidAppDriver.Current.FindElementById("com.android.sqlite:id/BtnSave");
            BtnSave.Click();
        }

        [Then(@"registro correcto de la lista")]
        public void ThenRegistroCorrectoDeLaLista()
        {
            //Assert de la lista
            throw new PendingStepException();
        }

        [Then(@"registro correcto esperando (.*)-(.*)")]
        public void ThenRegistroCorrectoEsperando(string codigo, string descripcion)
        {
            //Assert

            throw new PendingStepException();
        }
    }
}
