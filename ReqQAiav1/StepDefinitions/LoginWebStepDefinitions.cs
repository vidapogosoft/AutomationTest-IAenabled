using System;
using Reqnroll;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ReqQAiav1.StepDefinitions
{
    [Binding]
    public class LoginWebStepDefinitions
    {
        public IWebDriver driver;

        public string url = string.Empty;
        public string urlActual = string.Empty;

        public LoginWebStepDefinitions()
        {
            driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2026\");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [Given("usuario se dirige a website (.*)")]
        public void GivenUsuarioSeDirigeAWebsiteDato(string rutaweb)
        {
            url = rutaweb;
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [When("para ingresar digita su usuario (.*) y password (.*)")]
        public void WhenParaIngresarDigitaSuUsuarioDatoYPasswordDato(string user, string pwd)
        {
            //instancia de elementos
            driver.FindElement(By.Id("LoginUser_UserName"));
            driver.FindElement(By.Id("LoginUser_UserName")).Click();
            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys(user);

            driver.FindElement(By.Id("LoginUser_Password"));
            driver.FindElement(By.Id("LoginUser_Password")).Click();
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys(pwd);

            // Small pause can be removed; rely on waits
        }

        [When("realiza click sobre boton login para ingresar")]
        public void WhenRealizaClickSobreBotonLoginParaIngresar()
        {
            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();
        }

        [Then("login correctro en pagina (.*)")]
        public void ThenLoginCorrectroEnPaginaDato(string webhome)
        {

            urlActual = driver.Url; //obtiene la url actual del navegador

            //assert

            Assert.Equal(webhome, urlActual);
        }

        [Given("usuario se dirige al menu (.*)")]
        public void GivenUsuarioSeDirigeAlMenuDato(string menu)
        {
            // Opcional: desactivar implicit wait cuando uses explícitas
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);

            // Esperar a que la página esté lista
            var js = (IJavaScriptExecutor)driver;
            var ready = new WebDriverWait(driver, TimeSpan.FromSeconds(15))
                .Until(d => js.ExecuteScript("return document.readyState").ToString() == "complete");

            // Espera explícita hasta que el elemento sea clicable
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(d =>
            {
                var elems = d.FindElements(By.Id(menu));
                if (elems.Count == 0) return null;
                var el = elems[0];
                return (el.Displayed && el.Enabled) ? el : null;
            });

            element.Click();
        }

        [When("para ingresar un nuevo cliente")]
        public void WhenParaIngresarUnNuevoCliente()
        {
            Assert.True(true);
        }

        [Then("acceso correcto a la funcionalidad (.*)")]
        public void ThenAccesoCorrectoALaFuncionalidadDato(string func)
        { 
            urlActual = driver.Url; //obtiene la url actual del navegador
            Assert.Equal(func, urlActual);
        }

    }
}
