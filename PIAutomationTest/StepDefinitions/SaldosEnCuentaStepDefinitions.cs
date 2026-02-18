using System;
using TechTalk.SpecFlow;

using BankAccountNS;
using NUnit.Framework;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class SaldosEnCuentaStepDefinitions
    {
        public int beginningBalance;
        public int debitAmount;
        public int creditAmount;
        public double balance;
        
        [Given(@"Mi saldo inicial de dolares en cuenta es de (.*)")]
        public void GivenMiSaldoInicialDeDolaresEnCuentaEsDe(int montoinicial)
        {
            //Arrange
            beginningBalance = montoinicial;

        }

        [When(@"Se debita un monto en dolares de (.*)")]
        public void WhenSeDebitaUnMontoEnDolaresDe(int montodebito)
        {
            debitAmount = montodebito;

            BankAccount account = new BankAccount("vidapogosoft", beginningBalance);

            //Act

            account.Debit(debitAmount);

            //Asert

            balance = account.Balance;

        }

        [When(@"Se debita un monto en dolares negativo de (.*)")]
        public void WhenSeDebitaUnMontoEnDolaresNegativoDe(int montodebito)
        {

            debitAmount = montodebito;

            BankAccount account = new BankAccount("vidapogosoft", beginningBalance);

            //Act

            account.Debit(debitAmount);

            //Asert

            balance = account.Balance;
        }

        [When(@"Se acredita un monto en dolares de (.*)")]
        public void WhenSeAcreditaUnMontoEnDolaresDe(int montocredito)
        {
            creditAmount = montocredito;

            BankAccount account = new BankAccount("vidapogosoft", beginningBalance);

            //Act

            account.Credit(creditAmount);

            //Asert

            balance = account.Balance;
        }

        [Then(@"Saldo actual en cuenta de (.*)")]
        public void ThenSaldoActualEnCuentaDe(double saldocuenta)
        {
            //Assert
            Assert.AreEqual(balance, saldocuenta);

        }

    }
}
