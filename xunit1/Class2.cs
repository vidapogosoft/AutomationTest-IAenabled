using System.Collections.Generic;
using System.Linq;
using Xunit;
using xunit1;

namespace xunit1
{
    public class Class2
    {
        public static IEnumerable<object[]> DatosDePrueba =>
            new List<object[]>
            {
                new object[] {"reconocer", true},
                new object[] {"ana", true},
                new object[] {"A man, a plan, a canal: Pnama", true},
                new object[] {"oso", true},
            };


        public static IEnumerable<object[]> DatosDePruebaError =>
            new List<object[]>
            {
                new object[] {"victor", false},
                new object[] {"doe", false},
                new object[] {"hola", false},
                new object[] {"12345", false},
            };


        [Theory]
        [MemberData(nameof(DatosDePrueba))]
        public void EsPalindromoDatosValidos(string texto, bool resultadoEsperado)
        {

            //Arrange
            var verificador = new EsPalindromo();

            //Act
            var resultActual = verificador.VerificaPalabra(texto);

            //Assert
            Assert.Equal(resultadoEsperado, resultActual);
        }

        [Theory]
        [MemberData(nameof(DatosDePruebaError))]
        public void EsPalindromoDatosError(string texto, bool resultadoEsperado)
        {

            //Arrange
            var verificador = new EsPalindromo();

            //Act
            var resultActual = verificador.VerificaPalabra(texto);

            //Assert
            Assert.Equal(resultadoEsperado, resultActual);
        }

    }
}
