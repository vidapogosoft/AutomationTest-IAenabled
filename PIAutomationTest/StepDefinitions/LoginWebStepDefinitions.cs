using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class LoginWebStepDefinitions
    {
        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2023\SIPECOM\TestAutomatizadosFCME\herramientas\116\");

        //instancia de manera global la URL de la pagina a testear
        public string url = string.Empty;
        public string urlActual = string.Empty;

        [Given(@"Usuario se dirige a website (.*)")]
        public void GivenUsuarioSeDirigeAWebsite(string rutaweb)
        {
            url = rutaweb;

            //set de la pagina a probar
            driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de ventana
            driver.Manage().Window.Maximize();

        }

        [When(@"para ingresar digita su usuario (.*) y contraseña (.*)")]
        public void WhenParaIngresarDigitaSuUsuarioYContrasena(string user, string pwd)
        {
            //instancia de los campos a traves de find elements
            driver.FindElement(By.Id("LoginUser_UserName"));
            driver.FindElement(By.Id("LoginUser_UserName")).Click();
            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys(user);

            driver.FindElement(By.Id("LoginUser_Password"));
            driver.FindElement(By.Id("LoginUser_Password")).Click();
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys(pwd);

            Thread.Sleep(4000);
        }

        [When(@"realiza click sobre boton Login par ingresar")]
        public void WhenRealizaClickSobreBotonLoginParIngresar()
        {
            //localizar boton de login y hacer click
            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

            Thread.Sleep(4000);
        }

        [Then(@"login correcto en pagina (.*)")]
        public void ThenLoginCorrectoEnPagina(string webhome)
        {
            urlActual = driver.Url; //el driver me indica q url actual estoy

            //Assert
            Assert.AreEqual(webhome, urlActual);
        }

        [Given(@"Usuario se dirige al menu (.*)")]
        public void GivenUsuarioSeDirigeAlMenu(string licliente)
        {
            Thread.Sleep(4000);

            driver.FindElement(By.Id(licliente)).Click();

        }

        [When(@"para ingresar un nuevo cliente")]
        public void WhenParaIngresarUnNuevoCliente()
        {
            Thread.Sleep(4000);
        }

        [Then(@"acceso correcto a la funcionalidad (.*)")]
        public void ThenAccesoCorrectoALaFuncionalidad(string funcionalidad)
        {
            urlActual = driver.Url; //el driver me indica q url actual estoy

            //Assert
            Assert.AreEqual(funcionalidad, urlActual);
        }

        [Given(@"Usuario se dirige al boton (.*)")]
        public void GivenUsuarioSeDirigeAlBoton(string Add)
        {
            Thread.Sleep(3000);

            driver.FindElement(By.Id(Add)).Click();
        }

        [When(@"comienzo el registro de datos de nombres (.*)")]
        public void WhenComienzoElRegistroDeDatosDeNombres(string nombre)
        {
            Thread.Sleep(2000);

            //llenar el formulario

            driver.FindElement(By.Id("MainContent_txtNombreCliente"));
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys(nombre);
        }

        [When(@"tipo de identificacion (.*)")]
        public void WhenTipoDeIdentificacion(string tipodni)
        {
            Thread.Sleep(2000);

            var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
            var selectelement = new SelectElement(TipoIdent);
            selectelement.SelectByValue(tipodni);
            Thread.Sleep(2000);
        }

        [When(@"numero de identificacion (.*)")]
        public void WhenNumeroDeIdentificacion(string numdni)
        {
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtIdentificacion"));
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys(numdni);
        }

        [When(@"telefono convencional (.*)")]
        public void WhenTelefonoConvencional(string fonoconv)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys(fonoconv);
        }

        [When(@"direccion de contacto (.*)")]
        public void WhenDireccion(string direccion)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("MainContent_txtDireccion"));
            driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
            driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys(direccion);
        }

        [When(@"correo electronico (.*)")]
        public void WhenCorreo(string email)
        {
            Thread.Sleep(2000);
        }

        [Then(@"click sobre el boton guardar")]
        public void ThenClickSobreElBotonGuardar()
        {
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();

            Thread.Sleep(5000);
        }

        [When(@"usuario realiza LogOut")]
        public void WhenUsuarioRealizaLogOut()
        {
            Thread.Sleep(4000);
        }

        [Then(@"Salir de aplicacion")]
        public void ThenSalirDeAplicacion()
        {
            driver.Quit();
        }
    }
}
