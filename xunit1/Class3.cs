using Xunit;

namespace xunit1
{
    public class Class3
    {
        [Theory]
        [ClassData(typeof(DatosParaValidarPalindromos))]
        public void EsPalindromoDataClass(string texto, bool resultadoesperado) 
        {
            //Arrange
            var verificador = new EsPalindromo();

            //Act
            var resultActual = verificador.VerificaPalabra(texto);

            //Assert
            Assert.Equal(resultadoesperado, resultActual);

        }    
    }
}
