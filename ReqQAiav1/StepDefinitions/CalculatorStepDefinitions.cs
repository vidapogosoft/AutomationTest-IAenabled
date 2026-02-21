using Reqnroll.CommonModels;

namespace ReqQAiav1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.reqnroll.net/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Assert.Equal(120, result);
        }

        /// <summary>
        /// Escenario nuevo: Resta de dos numeros
        /// </summary>
        /// <param name="p0"></param>
        /// <exception cref="PendingStepException"></exception>

        [Given("el primer numero es {int}")]
        public void GivenElPrimerNumeroEs(int p0)
        {
            throw new PendingStepException();
        }

        [Given("el segundo numero es {int}")]
        public void GivenElSegundoNumeroEs(int p0)
        {
            throw new PendingStepException();
        }

        [When("los dos numeros deben ser restados")]
        public void WhenLosDosNumerosDebenSerRestados()
        {
            throw new PendingStepException();
        }

        [Then("el resultado debe ser {int}")]
        public void ThenElResultadoDebeSer(int resta)
        {
            Assert.Equal(0, resta);
        }


    }
}
