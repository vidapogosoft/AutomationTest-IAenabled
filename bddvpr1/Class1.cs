using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Xunit;

namespace bddvpr1
{
    public class Class1
    {

        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2025\");

        //instancia de manera global la URL de la pagina a testear
        public string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx";


        [Fact]
        public void test1()
        {
            //set de la pagina a probar
            driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de ventana
            driver.Manage().Window.Maximize();

            //instancia de los campos a traves de find elements
            driver.FindElement(By.Id("LoginUser_UserName"));
            driver.FindElement(By.Id("LoginUser_UserName")).Click();
            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("Demo");

            driver.FindElement(By.Id("LoginUser_Password"));
            driver.FindElement(By.Id("LoginUser_Password")).Click();
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

            Thread.Sleep(4000);

            //localizar boton de login y hacer click
            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

            Thread.Sleep(4000);

            driver.FindElement(By.Id("liClientes")).Click();

            Thread.Sleep(3000);

            driver.FindElement(By.Id("MainContent_btnAdd")).Click();
            Thread.Sleep(2000);

            //llenar el formulario

            driver.FindElement(By.Id("MainContent_txtNombreCliente"));
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("VPR-Agosto2023");
            Thread.Sleep(2000);

            var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
            var selectelement = new SelectElement(TipoIdent);
            selectelement.SelectByValue("05");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtIdentificacion"));
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0959143926");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("045114449");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtDireccion"));
            driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
            driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Direccion de domicilio");
            Thread.Sleep(2000);

            IWebElement check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
            check1.Click();

            driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("correo1@dominio.com");
            driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("correo2@dominio.com");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();

            Thread.Sleep(5000);

            this.driver.SwitchTo().Alert().Accept();


            Assert.True(true);
        }

    }
}
