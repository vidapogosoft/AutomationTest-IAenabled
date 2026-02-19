
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Xunit;

namespace seleniumtest1
{
    public class Class1
    {
        //inicializo el driver
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2026\");

        //instancia publica de la pagina web a testear
        public string url = "https://cpanel-safety.com/openfact/Account/Login.aspx";

        [Fact]
        public void test1()
        {

            //set de pagina a probar pasar la url
            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            //realizo los findelements de la pagina del browser
            driver.FindElement(By.Id("LoginUser_UserName"));
            driver.FindElement(By.Id("LoginUser_UserName")).Click();
            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("demo");

            driver.FindElement(By.Id("LoginUser_Password"));
            driver.FindElement(By.Id("LoginUser_Password")).Click();
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

            Thread.Sleep(4000);

            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

            Thread.Sleep(4000);

            //Trabajar con mas secciones de la pagina
            driver.FindElement(By.Id("liClientes")).Click();

            Thread.Sleep(4000);

            driver.FindElement(By.Id("MainContent_btnAdd")).Click();

            Thread.Sleep(4000);

            //enviar datos de pruebas

            driver.FindElement(By.Id("MainContent_txtNombreCliente"));
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("VPR Victor Portugal");

            var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
            var selectelement = new SelectElement(TipoIdent);
            selectelement.SelectByValue("04");

            Thread.Sleep(4000);

            driver.FindElement(By.Id("MainContent_txtIdentificacion"));
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0924258136001");


            driver.FindElement(By.Id("MainContent_txtDireccion"));
            driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
            driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("ALBO 12 ECU GYE NORTE");

            driver.FindElement(By.Id("MainContent_txtMailDefecto"));
            driver.FindElement(By.Id("MainContent_txtMailDefecto")).Click();
            driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("vidapogosoft@gmail.com");

            driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente"));
            driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).Click();
            driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("vidapogosoft@hotmail.com");

            Thread.Sleep(4000);

            IWebElement check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
            check1.Click();

            Thread.Sleep(4000);

            driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();

            Thread.Sleep(4000);

            driver.SwitchTo().Alert().Accept();

            //driver.Quit();

            Assert.True(true);
        }

    }
}
