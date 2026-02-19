
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Xunit;

namespace seleniumtest1
{
    public class Ejemplo2
    {
        //inicializo el driver
        //public IWebDriver driver = new EdgeDriver(@"D:\vidapogosoft\cursos\2025\edge\");
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2026\");

        //instancia publica de la pagina web a testear
        public string url = "http://tizag.com/phpT/examples/formex.php";


        [Fact]
        public void test2()
        {

            //set de pagina a probar pasar la url
            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            IWebElement control = driver.FindElement(By.Name("Fname"));
            control.SendKeys("VPR - 1");

            driver.FindElement(By.Name("Lname")).SendKeys("vidapogosoft");

            driver.FindElement(By.XPath("//input[@name='gender' and @value='Male']")).Click();

            driver.FindElement(By.XPath("//input[@name='food[]' and @value='Chicken']")).Click();

            driver.FindElement(By.Name("quote")).SendKeys("TEST DE BDD EXAMPLE");

            //drop down list
            var education =  driver.FindElement(By.Name("education"));
            var selectelement = new SelectElement(education);

            //select by value
            selectelement.SelectByValue("Jr.High");

            Thread.Sleep(4000);

            selectelement.SelectByText("HighSchool");

            Thread.Sleep(4000);

            //Take foto

            ITakesScreenshot foto = driver as ITakesScreenshot;
            Screenshot screen = foto.GetScreenshot();

            screen.SaveAsFile(@"D:\seleniumtest1\" + DateTime.Now.Ticks.ToString() + ".png");

            Assert.True(true);
        }


    }
}
