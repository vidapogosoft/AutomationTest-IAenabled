using System;
using Reqnroll;
using ReqnrollProject2.Drivers;

namespace ReqnrollProject2.StepDefinitions
{
    [Binding]
    public class DataDriverTableStepDefinitions
    {
        [Given("con lo siguientes numeros")]
        public void GivenConLoSiguientesNumeros(DataTable dataTable)
        {
            // firstordefault (one)
            var datostest = dataTable.CreateInstance<DatosTable>();

            var dato1 = datostest.Dato1;
            var dato2 = datostest.Dato2;



            throw new PendingStepException();
        }

        [Given("con lo siguientes numeros de la tabla")]
        public void GivenConLoSiguientesNumerosDeLaTabla(DataTable dataTable)
        {
            int dato1 = 0, dato2 = 0;

            //set de datos multiples
            var datostest = dataTable.CreateSet<DatosTable>();

            foreach(var usodata in datostest)
            {
                dato1 = usodata.Dato1;
                dato2 = usodata.Dato2;

                //proceso a realizar

            }


            throw new PendingStepException();
        }


        [When("realizar la sumatoria")]
        public void WhenRealizarLaSumatoria()
        {
            throw new PendingStepException();
        }

        [Then("el resultado a validar debe ser {int}")]
        public void ThenElResultadoAValidarDebeSer(int p0)
        {
            throw new PendingStepException();
        }
    }
}
