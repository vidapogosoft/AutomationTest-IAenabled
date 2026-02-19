using NUnit.Framework;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

using System;

namespace NetWinAppDriver1
{
    public class Tests
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [SetUp]
        public void Setup()
        {
            AppiumOptions options = new AppiumOptions();

            options.AddAdditionalCapability("app", "C:\\Windows\\System32\\notepad.exe");
            options.AddAdditionalCapability("deviceName", "PORTUGALASUS");

            DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), options);

            Assert.IsNotNull(DesktopSession);

        }

        [Test]
        public void TestNotePad()
        {

            WindowsElement NoteArea = DesktopSession.FindElementByAccessibilityId("15");
            NoteArea.SendKeys("Curso de AUTOMATIZACION DE PRUEBAS");

            Assert.IsNotNull("OK", NoteArea.Text);

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }


        [TearDown]
        public void Close()
        {
            DesktopSession.CloseApp();
        }

    }
}